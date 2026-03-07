using System.Net;

namespace Blaze.Core;

public interface IBlazeConnection
{
    Guid Id { get; }
    EndPoint? RemoteEndPoint { get; }
    EndPoint? LocalEndPoint { get; }
    bool Connected { get; }
    object? State { get; set; }
    DateTime LastActivityTime { get; set; }
}
