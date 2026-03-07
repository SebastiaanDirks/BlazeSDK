namespace Blaze.Core;

/// <summary>
/// REST metadata for a command — mirrors the official Blaze RestResourceInfo struct.
/// Links an HTTP method + URL path to a Blaze component/command.
/// </summary>
public class RestResourceInfo
{
    public string? ApiVersion { get; init; }
    public required string ResourcePath { get; init; }
    public required HttpMethod Method { get; init; }
    public ushort ComponentId { get; init; }
    public ushort CommandId { get; init; }
    public string? ContentType { get; init; }

    /// <summary>
    /// Matches a URL path (e.g., "/authentication/login") against this resource.
    /// Supports template parameters in the resource path (e.g., "authentication/{userId}/login").
    /// </summary>
    public bool Matches(HttpMethod method, string urlPath)
    {
        if (Method != method) return false;
        if (string.IsNullOrEmpty(urlPath)) return false;

        // Strip leading slash
        ReadOnlySpan<char> path = urlPath.AsSpan();
        if (path.Length > 0 && path[0] == '/')
            path = path.Slice(1);

        // Strip query string
        int queryIdx = path.IndexOf('?');
        if (queryIdx >= 0)
            path = path.Slice(0, queryIdx);

        string remainingPath = path.ToString();
        return MatchesResourcePath(ResourcePath, remainingPath);
    }

    /// <summary>
    /// Extracts template parameter values from a URL path.
    /// For example, given ResourcePath "authentication/{userId}/login" and URL path "/1/authentication/12345/login",
    /// returns { "userId" = "12345" }.
    /// </summary>
    public Dictionary<string, string>? ExtractTemplateParameters(string urlPath)
    {
        ReadOnlySpan<char> path = urlPath.AsSpan();
        if (path.Length > 0 && path[0] == '/')
            path = path.Slice(1);

        int queryIdx = path.IndexOf('?');
        if (queryIdx >= 0)
            path = path.Slice(0, queryIdx);

        string remainingPath = path.ToString();
        return ExtractTemplateParametersFromPath(ResourcePath, remainingPath);
    }

    /// <summary>
    /// Template-aware path matching, faithfully translating the official C++ RestResourceInfo::equals() method.
    /// Template tokens like {userId} match any path segment value.
    /// </summary>
    private static bool MatchesResourcePath(string templatePath, string actualPath)
    {
        int ti = 0, ai = 0;

        while (ti < templatePath.Length && ai < actualPath.Length)
        {
            if (templatePath[ti] == actualPath[ai])
            {
                ti++;
                ai++;
                continue;
            }

            // Mismatch — if the template char is '{', this is a template token
            if (templatePath[ti] == '{')
            {
                // Skip the template token (until next '/' or end of string)
                ti++;
                while (ti < templatePath.Length && templatePath[ti] != '/')
                    ti++;

                // Verify the token was properly closed with '}'
                if (ti == 0 || templatePath[ti - 1] != '}')
                    return false;

                // Skip the corresponding actual path segment value
                while (ai < actualPath.Length && actualPath[ai] != '/')
                    ai++;
            }
            else
            {
                return false;
            }
        }

        // Handle trailing template token with no actual value
        if (ai >= actualPath.Length && ti < templatePath.Length && templatePath[ti] == '{')
        {
            ti++;
            while (ti < templatePath.Length && templatePath[ti] != '/')
                ti++;

            if (ti == 0 || templatePath[ti - 1] != '}')
                return false;
        }

        return ti >= templatePath.Length && ai >= actualPath.Length;
    }

    private static Dictionary<string, string>? ExtractTemplateParametersFromPath(string templatePath, string actualPath)
    {
        var parameters = new Dictionary<string, string>();
        int ti = 0, ai = 0;

        while (ti < templatePath.Length && ai < actualPath.Length)
        {
            if (templatePath[ti] == actualPath[ai])
            {
                ti++;
                ai++;
                continue;
            }

            if (templatePath[ti] == '{')
            {
                int tokenStart = ti + 1;
                ti++;
                while (ti < templatePath.Length && templatePath[ti] != '/')
                    ti++;

                if (ti == 0 || templatePath[ti - 1] != '}')
                    return null;

                string paramName = templatePath.Substring(tokenStart, ti - 1 - tokenStart);

                int valueStart = ai;
                while (ai < actualPath.Length && actualPath[ai] != '/')
                    ai++;

                string paramValue = Uri.UnescapeDataString(actualPath.Substring(valueStart, ai - valueStart));
                parameters[paramName] = paramValue;
            }
            else
            {
                return null;
            }
        }

        return parameters;
    }

    /// <summary>
    /// Parses an HTTP method string into the HttpMethod enum.
    /// </summary>
    public static HttpMethod ParseMethod(string method)
    {
        return method.ToUpperInvariant() switch
        {
            "GET" => HttpMethod.GET,
            "HEAD" => HttpMethod.HEAD,
            "POST" => HttpMethod.POST,
            "PUT" => HttpMethod.PUT,
            "DELETE" => HttpMethod.DELETE,
            "PATCH" => HttpMethod.PATCH,
            _ => throw new ArgumentException($"Unknown HTTP method: {method}")
        };
    }

    /// <summary>
    /// Returns the HTTP method name string.
    /// </summary>
    public static string GetMethodName(HttpMethod method)
    {
        return method switch
        {
            HttpMethod.GET => "GET",
            HttpMethod.HEAD => "HEAD",
            HttpMethod.POST => "POST",
            HttpMethod.PUT => "PUT",
            HttpMethod.DELETE => "DELETE",
            HttpMethod.PATCH => "PATCH",
            _ => throw new ArgumentException($"Unknown HTTP method: {method}")
        };
    }
}
