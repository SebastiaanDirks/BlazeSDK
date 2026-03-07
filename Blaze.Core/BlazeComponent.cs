using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaze.Core;

public abstract class BlazeComponent : IBlazeComponent
{
    private Dictionary<ushort, IRpcCommandFunc> _commandFuncs = new();
    private Dictionary<ushort, IRpcNotificationFunc> _notificationFuncs = new();

    private string? _restBasePath;

    public abstract ushort Id { get; }
    public abstract string Name { get; }
    public abstract string GetErrorName(ushort errorCode);

    public string RestBasePath
    {
        get
        {
            if (_restBasePath == null)
            {
                string name = Name;
                if (name.EndsWith("Component", StringComparison.OrdinalIgnoreCase))
                    name = name[..^"Component".Length];
                _restBasePath = name.ToLowerInvariant();
            }
            return _restBasePath;
        }
    }

    public bool RegisterCommand(IRpcCommandFunc commandFunc)
    {
        return _commandFuncs.TryAdd(commandFunc.Id, commandFunc);
    }

    public IRpcCommandFunc? GetCommandFunc(ushort commandId)
    {
        _commandFuncs.TryGetValue(commandId, out var commandFunc);
        return commandFunc;
    }

    public IRpcCommandFunc? GetCommandByName(string commandName)
    {
        foreach (var cmd in _commandFuncs.Values)
        {
            if (cmd.Name.Equals(commandName, StringComparison.OrdinalIgnoreCase))
                return cmd;
        }
        return null;
    }

    public IRpcCommandFunc? GetRestCommandFunc(HttpMethod method, string path)
    {
        foreach (var commandFunc in _commandFuncs.Values)
        {
            if (commandFunc.RestResourceInfo?.Matches(method, path) == true)
                return commandFunc;
        }
        return null;
    }

    public bool RegisterNotification(IRpcNotificationFunc notificationFunc)
    {
        return _notificationFuncs.TryAdd(notificationFunc.Id, notificationFunc);
    }
    public IRpcNotificationFunc? GetNotificationFunc(ushort notificationId)
    {
        _notificationFuncs.TryGetValue(notificationId, out var notificationFunc);
        return notificationFunc;
    }
}
