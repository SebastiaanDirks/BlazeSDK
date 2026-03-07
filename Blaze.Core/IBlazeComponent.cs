namespace Blaze.Core;

public interface IBlazeComponent
{
    ushort Id { get; }
    string Name { get; }
    string RestBasePath { get; }
    string GetErrorName(ushort errorCode);
    IRpcCommandFunc? GetCommandFunc(ushort commandId);
    IRpcCommandFunc? GetCommandByName(string commandName);
    IRpcCommandFunc? GetRestCommandFunc(HttpMethod method, string path);
    IRpcNotificationFunc? GetNotificationFunc(ushort notificationId);
}
