using Blaze.Core;
using Blaze.Hosting.Internal;
using HttpMethod = Blaze.Core.HttpMethod;
using EATDF;
using EATDF.Serialization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ProtoFire;
using ProtoFire.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Blaze.Hosting;

public abstract class BlazeServerContext : IBlazeServerCallbacks
{
    class ServerRouter(IDictionary<ushort, IBlazeComponent> components, Dictionary<ushort, string> errorNames) : IBlazeRouter
    {
        public IBlazeComponent? GetComponent(ushort id)
        {
            return components.TryGetValue(id, out IBlazeComponent? component) ? component : null;
        }

        public (IBlazeComponent component, IRpcCommandFunc command)? ResolveRestCommand(HttpMethod method, string path)
        {
            foreach (var component in components.Values)
            {
                var commandFunc = component.GetRestCommandFunc(method, path);
                if (commandFunc != null)
                    return (component, commandFunc);
            }

            ReadOnlySpan<char> p = path.AsSpan();
            if (p.Length > 0 && p[0] == '/') p = p[1..];
            int qIdx = p.IndexOf('?');
            if (qIdx >= 0) p = p[..qIdx];
            int firstSlash = p.IndexOf('/');
            if (firstSlash < 0) return null;
            string componentPrefix = p[..firstSlash].ToString();
            string commandName = p[(firstSlash + 1)..].ToString();
            int secondSlash = commandName.IndexOf('/');
            if (secondSlash >= 0) commandName = commandName[..secondSlash];
            if (componentPrefix.Length == 0 || commandName.Length == 0) return null;

            foreach (var component in components.Values)
            {
                if (component.RestBasePath.Equals(componentPrefix, StringComparison.OrdinalIgnoreCase))
                {
                    var cmd = component.GetCommandByName(commandName);
                    if (cmd != null)
                        return (component, cmd);
                }
            }

            return null;
        }

        public string GetErrorName(int errorCode)
        {
            ushort error = (ushort)(errorCode >> 16);

            if ((error & 0xC000) == 0)
            {
                //component error
                ushort componentId = (ushort)(errorCode & 0xFFFF);

                IBlazeComponent? component = GetComponent(componentId);
                if (component != null)
                    return component.GetErrorName(error);
            }
            else
            {
                //global error or sdk error
                if (errorNames.TryGetValue(error, out string? name))
                    return name;
            }

            return errorCode.ToString();
        }
    }

    private IServiceProvider _serviceProvider = null!;
    private BlazeBackgroundService _hostingService = null!;
    private BlazeServerContextOptions? _options = null;
    private Dictionary<ushort, IBlazeComponent> _components = new();

    public IEnumerable<IBlazeComponent> Components => _components.Values;


    internal void Initialize(IServiceProvider provider, BlazeBackgroundService hostingService)
    {
        _serviceProvider = provider;
        _hostingService = hostingService;

        _options = GetOptions();
        foreach (Type componentType in _options.MappedComponents)
        {
            IBlazeComponent component = (IBlazeComponent)ActivatorUtilities.CreateInstance(provider, componentType);
            if (!_components.TryAdd(component.Id, component))
                throw new InvalidOperationException($"Component with id {component.Id} already exists");
        }

        foreach (IPEndPoint endPoint in _options.EndPoints)
        {
            EndpointType endpointType = _options.EndpointTypes.GetValueOrDefault(endPoint, EndpointType.Rpc);
            UseEndpoint(endPoint, endpointType);
        }
    }

    internal void UseEndpoint(IPEndPoint localEndPoint, EndpointType endpointType = EndpointType.Rpc)
    {
        BlazeServerContextOptions options = GetOptions();
        IBlazeRouter router = new ServerRouter(_components, options.BaseErrorNames);

        if (endpointType is EndpointType.Rpc or EndpointType.Both)
        {
            ITdfSerializer serializer = options.TdfSerializer switch
            {
                TdfSerializerType.Heat => new HeatSerializer(),
                TdfSerializerType.Heat2 => new Heat2Serializer(options.TdfRegistry, options.Heat1BackCompatibility),
                TdfSerializerType.Xml => new XmlSerializer(),
                _ => throw new ArgumentException("Invalid serializer type")
            };

            BlazeServerConfig rpcConfig = new BlazeServerConfig()
            {
                Backlog = options.Backlog,
                CallbackHandler = this,
                LocalEndpoint = localEndPoint,
                PacketFrameEncoding = options.FrameEncoding,
                Serializer = serializer,
                Secure = options.Secure,
                EndpointType = endpointType,
                Router = router
            };

            BlazeServer blazeServer = new BlazeServer(rpcConfig, _serviceProvider.GetRequiredService<ILogger<BlazeServer>>());
            _hostingService.AddBlazeServer(blazeServer);
        }

        if (endpointType is EndpointType.Rest or EndpointType.Both)
        {
            IPEndPoint restEndPoint = endpointType == EndpointType.Both
                ? new IPEndPoint(localEndPoint.Address, localEndPoint.Port == 0 ? 0 : localEndPoint.Port + 1)
                : localEndPoint;

            BlazeServerConfig restConfig = new BlazeServerConfig()
            {
                Backlog = options.Backlog,
                CallbackHandler = this,
                LocalEndpoint = restEndPoint,
                EndpointType = EndpointType.Rest,
                Secure = options.Secure,
                Certificate = options.Certificate,
                Router = router
            };

            BlazeRestServer restServer = new BlazeRestServer(restConfig, _serviceProvider.GetRequiredService<ILogger<BlazeRestServer>>());
            _hostingService.AddRestServer(restServer);
        }
    }

    protected virtual void OnConfiguring(BlazeServerContextOptions options, IServiceProvider provider) { }

    BlazeServerContextOptions GetOptions()
    {
        if (_options != null)
            return _options;

        _options = new BlazeServerContextOptions();
        OnConfiguring(_options, _serviceProvider);

        Action<BlazeServerContextOptions, IServiceProvider>? configurer = _serviceProvider.GetKeyedService<Action<BlazeServerContextOptions, IServiceProvider>>(GetType());
        if (configurer != null)
            configurer(_options, _serviceProvider);

        return _options;
    }

    public virtual Task<bool> OnConnectedAsync(BlazeRpcConnection connection)
    {
        return Task.FromResult(true);
    }

    public virtual Task OnAuthenticatedAsync(BlazeRpcConnection connection, bool secure)
    {
       
        return Task.CompletedTask;
    }

    public virtual Task OnDisconnectedAsync(BlazeRpcConnection connection)
    {
        return Task.CompletedTask;
    }

    public virtual Task OnErrorAsync(BlazeRpcConnection connection, Exception exception)
    {
        return Task.CompletedTask;
    }

    public virtual Task OnRpcCommandErrorAsync(BlazeRpcConnection connection, ProtoFirePacket packet, Tdf request, Exception exception)
    {
        return Task.CompletedTask;
    }

    public virtual Task OnUnhandledAsync(BlazeRpcConnection connection, ProtoFirePacket packet, bool corrupted)
    {
        return Task.CompletedTask;
    }

    public virtual ProtoSSLCertificate? SelectCertificate(BlazeRpcConnection connection)
    {
        return GetOptions().Certificate;
    }
}
