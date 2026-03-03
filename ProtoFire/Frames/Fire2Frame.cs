namespace ProtoFire.Frames;

/// <summary>
/// Fire2 frame format — fixed 16-byte header.
/// Wire layout:
///   [0-3]  PayloadSize  (uint32, big-endian) — size of TDF body only (excludes metadata)
///   [4-5]  MetadataSize (uint16, big-endian) — size of Heat2-encoded metadata
///   [6-7]  Component    (uint16, big-endian)
///   [8-9]  Command      (uint16, big-endian)
///   [10-12] MessageNum  (24-bit, big-endian)
///   [13]   MsgType(3 bits) | UserIndex(5 bits)
///   [14]   Options
///   [15]   Reserved (0)
///
/// After the header: [MetadataSize bytes] [PayloadSize bytes]
/// </summary>
public class Fire2Frame : IFireFrame
{
    public const byte HEADER_SIZE = 16;
    public const ushort METADATA_SIZE_MAX = 512;

    public const byte OPTION_NONE = 0x00;
    public const byte OPTION_IMMEDIATE = 0x01;

    public const uint MSGNUM_MASK = 0x00FFFFFF;

    public byte[] Frame { get; private set; }

    // ErrorCode is not part of the Fire2 wire header.
    private ushort _errorCode;

    public Fire2Frame()
    {
        Frame = new byte[HEADER_SIZE];
    }

    public void WriteTo(Stream stream)
    {
        stream.Write(Frame, 0, HEADER_SIZE);
    }

    public async Task WriteToAsync(Stream stream)
    {
        await stream.WriteAsync(Frame, 0, HEADER_SIZE).ConfigureAwait(false);
    }

    public int HeaderSize => HEADER_SIZE;

    /// <summary>Bytes 0-3: size of the TDF payload (excludes metadata).</summary>
    public uint PayloadSize
    {
        get => (uint)(Frame[0] << 24 | Frame[1] << 16 | Frame[2] << 8 | Frame[3]);
        set
        {
            Frame[0] = (byte)(value >> 24);
            Frame[1] = (byte)(value >> 16);
            Frame[2] = (byte)(value >> 8);
            Frame[3] = (byte)value;
        }
    }

    /// <summary>Bytes 4-5: size of the Heat2-encoded metadata.</summary>
    public ushort MetadataSize
    {
        get => (ushort)(Frame[4] << 8 | Frame[5]);
        set
        {
            Frame[4] = (byte)(value >> 8);
            Frame[5] = (byte)value;
        }
    }

    /// <summary>IFireFrame.Size maps to PayloadSize (TDF body only).</summary>
    public uint Size
    {
        get => PayloadSize;
        set => PayloadSize = value;
    }

    /// <summary>Total bytes after the 16-byte header (metadata + payload).</summary>
    public uint BodySize => (uint)MetadataSize + PayloadSize;

    public ushort Component
    {
        get => (ushort)(Frame[6] << 8 | Frame[7]);
        set { Frame[6] = (byte)(value >> 8); Frame[7] = (byte)value; }
    }

    public ushort Command
    {
        get => (ushort)(Frame[8] << 8 | Frame[9]);
        set { Frame[8] = (byte)(value >> 8); Frame[9] = (byte)value; }
    }

    /// <summary>Bytes 10-12: 24-bit message number.</summary>
    public uint MessageNum
    {
        get => (uint)(Frame[10] << 16 | Frame[11] << 8 | Frame[12]);
        set
        {
            Frame[10] = (byte)(value >> 16);
            Frame[11] = (byte)(value >> 8);
            Frame[12] = (byte)value;
        }
    }

    /// <summary>Byte 13 upper 3 bits: message type.</summary>
    public MessageType MessageType
    {
        get => (MessageType)(Frame[13] >> 5);
        set => Frame[13] = (byte)(((byte)value << 5) | (Frame[13] & 0x1F));
    }

    /// <summary>Byte 13 lower 5 bits: user index.</summary>
    public byte UserIndex
    {
        get => (byte)(Frame[13] & 0x1F);
        set => Frame[13] = (byte)((Frame[13] & 0xE0) | (value & 0x1F));
    }

    /// <summary>Byte 14: option flags.</summary>
    public byte Options
    {
        get => Frame[14];
        set => Frame[14] = value;
    }

    public bool IsImmediate => (Options & OPTION_IMMEDIATE) != 0;

    /// <summary>
    /// ErrorCode is NOT part of the Fire2 wire header.
    /// </summary>
    public ushort ErrorCode
    {
        get => _errorCode;
        set => _errorCode = value;
    }

    public int FullErrorCode
    {
        get
        {
            if (_errorCode <= 0)
                return 0;

            if ((_errorCode & 0x4000) != 0)
                return _errorCode << 16; // global error
            return _errorCode << 16 | Component; // component error
        }
    }

    /// <summary>
    /// Context is NOT part of the Fire2 wire header.
    /// </summary>
    public ulong Context { get; set; }

    public FrameType Type => FrameType.Fire2Frame;

    public void Initialize(Stream stream)
    {
        stream.ReadExactly(Frame, 0, HEADER_SIZE);
    }

    public async Task InitializeAsync(Stream stream)
    {
        await stream.ReadExactlyAsync(Frame, 0, HEADER_SIZE).ConfigureAwait(false);
    }

    public IFireFrame CreateResponseFrame() => CreateResponseFrame(0);

    public IFireFrame CreateResponseFrame(ushort errorCode)
    {
        Fire2Frame respFrame = new Fire2Frame();
        respFrame.Component = Component;
        respFrame.Command = Command;
        respFrame.MessageNum = MessageNum;
        respFrame.UserIndex = UserIndex;
        respFrame.MessageType = errorCode == 0 ? MessageType.Reply : MessageType.ErrorReply;
        respFrame.ErrorCode = errorCode;
        return respFrame;
    }
}
