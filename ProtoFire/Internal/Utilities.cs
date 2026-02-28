namespace ProtoFire.Internal;

internal static class Utilities
{
    public static void ValidateFrameType(FrameType frameType)
    {
        if (frameType == FrameType.FireFrame)
            return;

        if (frameType == FrameType.Fire2Frame)
            return;

        throw new NotSupportedException("Unknown frame type");

    }


}
