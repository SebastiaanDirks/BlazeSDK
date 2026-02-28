namespace ProtoFire.Frames;

public class Fire2Frame : IFireFrame
{
    public const byte MIN_HEADER_SIZE = 12;
    public const byte MAX_HEADER_SIZE = MIN_HEADER_SIZE + EXTRA_HEADER_SIZE_MAX; //22

    private const byte JUMBO_SIZE = sizeof(ushort); //2
    private const byte JUMBO_CONTEXT_SIZE = sizeof(ulong); //8
    private const byte SMALL_CONTEXT_SIZE = sizeof(uint); //4
    private const byte EXTRA_HEADER_SIZE_MAX = JUMBO_SIZE + JUMBO_CONTEXT_SIZE;

    private uint _totalLength; // Tracks the 4-byte prefix wrapper length

    [Flags]
    public enum Option
    {
        NONE = 0x0,
        JUMBO_FRAME = 0x1,
        HAS_CONTEXT = 0x2,
        IMMEDIATE = 0x4,
        JUMBO_CONTEXT = 0x8
    }

    public byte[] Frame { get; private set; }

    public Fire2Frame()
    {
        Frame = new byte[MAX_HEADER_SIZE];
    }

    public void WriteTo(Stream stream)
    {
        byte[] prefix = new byte[4];
        prefix[0] = (byte)(_totalLength >> 24);
        prefix[1] = (byte)(_totalLength >> 16);
        prefix[2] = (byte)(_totalLength >> 8);
        prefix[3] = (byte)_totalLength;

        stream.Write(prefix, 0, 4);
        stream.Write(Frame, 0, HeaderSize);
    }

    public async Task WriteToAsync(Stream stream)
    {
        byte[] prefix = new byte[4];
        prefix[0] = (byte)(_totalLength >> 24);
        prefix[1] = (byte)(_totalLength >> 16);
        prefix[2] = (byte)(_totalLength >> 8);
        prefix[3] = (byte)_totalLength;

        await stream.WriteAsync(prefix, 0, 4).ConfigureAwait(false);
        await stream.WriteAsync(Frame, 0, HeaderSize).ConfigureAwait(false);
    }

    public int HeaderSize => MIN_HEADER_SIZE + ExtraHeaderSize;

    public uint Size
    {
        get
        {
            // The true size of the payload is the Wrapper Length minus the Header Length
            return _totalLength;
        }
        set
        {
            _totalLength = value;
            
            // EA "Fire2" protocol intentionally zeros out the legacy size fields
            Frame[0] = 0;
            Frame[1] = 0;
        }
    }

    public ushort Component
    {
        get => (ushort)(Frame[2] << 8 | Frame[3]);
        set { Frame[2] = (byte)(value >> 8); Frame[3] = (byte)value; }
    }

    public ushort Command
    {
        get => (ushort)(Frame[4] << 8 | Frame[5]);
        set { Frame[4] = (byte)(value >> 8); Frame[5] = (byte)value; }
    }

    public ushort ErrorCode
    {
        get => (ushort)(Frame[6] << 8 | Frame[7]);
        set { Frame[6] = (byte)(value >> 8); Frame[7] = (byte)value; }
    }

    public MessageType MessageType
    {
        get => (MessageType)(Frame[8] >> 4 & 0xF);
        set => Frame[8] = (byte)(Frame[8] & 0xF | (byte)value << 4);
    }

    public int FullErrorCode
    {
        get
        {
            ushort errCode = ErrorCode;
            if (errCode <= 0)
                return 0;

            if ((errCode & 0x4000) != 0)
                return errCode << 16; // global error
            return errCode << 16 | Component; // component error
        }
    }

    public byte UserIndex
    {
        get => (byte)(Frame[8] & 0xF);
        set => Frame[8] = (byte)(Frame[8] & 0xF0 | (byte)(value & 0xF));
    }

    public uint MessageNum
    {
        get => (uint)((Frame[9] & 0xF) << 16 | Frame[10] << 8 | Frame[11]);
        set
        {
            Frame[9] = (byte)(Frame[9] & 0xF0 | (byte)(value >> 16 & 0xF));
            Frame[10] = (byte)(value >> 8);
            Frame[11] = (byte)value;
        }
    }

    public ulong Context
    {
        get
        {
            ulong context = 0;
            if (OptionEnabled(Option.HAS_CONTEXT))
            {
                byte pos = MIN_HEADER_SIZE;
                if (OptionEnabled(Option.JUMBO_FRAME)) pos += JUMBO_SIZE;
                
                context = (ulong)Frame[pos + 0] << 24 | (ulong)Frame[pos + 1] << 16 | (ulong)Frame[pos + 2] << 8 | (ulong)Frame[pos + 3] << 0;

                if (OptionEnabled(Option.JUMBO_CONTEXT))
                {
                    context |= (ulong)Frame[pos + 4] << 56 | (ulong)Frame[pos + 5] << 48 | (ulong)Frame[pos + 6] << 40 | (ulong)Frame[pos + 7] << 32;
                }
            }
            return context;
        }
        set
        {
            byte pos = MIN_HEADER_SIZE;
            if (OptionEnabled(Option.JUMBO_FRAME)) pos += 2;

            if (OptionEnabled(Option.HAS_CONTEXT))
            {
                Frame[pos + 0] = (byte)(value >> 24); Frame[pos + 1] = (byte)(value >> 16);
                Frame[pos + 2] = (byte)(value >> 8);  Frame[pos + 3] = (byte)(value >> 0);
                if (OptionEnabled(Option.JUMBO_CONTEXT))
                {
                    Frame[pos + 4] = (byte)(value >> 56); Frame[pos + 5] = (byte)(value >> 48);
                    Frame[pos + 6] = (byte)(value >> 40); Frame[pos + 7] = (byte)(value >> 32);
                }
            }
        }
    }

    public Option Options
    {
        get => (Option)(Frame[9] >> 4 & 0xF);
        set => Frame[9] = (byte)(Frame[9] & 0xF | (byte)value << 4);
    }

    public ushort ExtraHeaderSize => 0;

    public FrameType Type => FrameType.Fire2Frame;

    public bool OptionEnabled(Option option) => (Options & option) == option;

    public void Initialize(Stream stream)
    {
        byte[] prefix = new byte[4];
        stream.ReadExactly(prefix, 0, 4);
        _totalLength = (uint)(prefix[0] << 24 | prefix[1] << 16 | prefix[2] << 8 | prefix[3]);

        // Only read exactly the 12 byte header. Do not read extra context bytes.
        stream.ReadExactly(Frame, 0, MIN_HEADER_SIZE);
    }

    public async Task InitializeAsync(Stream stream)
    {
        byte[] prefix = new byte[4];
        await stream.ReadExactlyAsync(prefix, 0, 4).ConfigureAwait(false);
        _totalLength = (uint)(prefix[0] << 24 | prefix[1] << 16 | prefix[2] << 8 | prefix[3]);

        // Only read exactly the 12 byte header. Do not read extra context bytes.
        await stream.ReadExactlyAsync(Frame, 0, MIN_HEADER_SIZE).ConfigureAwait(false);
    }

    public IFireFrame CreateResponseFrame() => CreateResponseFrame(0);
    
    public IFireFrame CreateResponseFrame(ushort errorCode)
    {
        Fire2Frame respFrame = new Fire2Frame();
        Buffer.BlockCopy(Frame, 0, respFrame.Frame, 0, MAX_HEADER_SIZE);
        respFrame.MessageType = errorCode == 0 ? MessageType.Reply : MessageType.ErrorReply;
        respFrame.ErrorCode = errorCode;
        return respFrame;
    }
}