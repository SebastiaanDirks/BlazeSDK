namespace Blaze.Core.Internal;

/// <summary>
/// Encodes/decodes Fire2 metadata (Heat2-encoded TDF with context and error code).
/// Avoids circular dependency on Blaze15SDK by encoding the raw Heat2 bytes directly.
///
/// Fire2Metadata TDF fields (relevant subset):
///   CNTX (0x8EED3800) - UInt64 (Heat2 Integer type 0x00)
///   ERRC (0x972CA300) - Int32  (Heat2 Integer type 0x00)
/// </summary>
internal static class Fire2MetadataHelper
{
    // Heat2 tag bytes for CNTX field (tag 0x8EED3800, type Integer=0x00)
    private static readonly byte[] CNTX_HEADER = [0x8E, 0xED, 0x38, 0x00];

    // Heat2 tag bytes for ERRC field (tag 0x972CA300, type Integer=0x00)
    private static readonly byte[] ERRC_HEADER = [0x97, 0x2C, 0xA3, 0x00];

    public static byte[] Encode(ulong context, ushort errorCode)
    {
        if (context == 0 && errorCode == 0)
            return Array.Empty<byte>();

        MemoryStream ms = new MemoryStream(32);

        if (context != 0)
        {
            ms.Write(CNTX_HEADER);
            WriteVarInt(ms, unchecked((long)context));
        }

        if (errorCode != 0)
        {
            ms.Write(ERRC_HEADER);
            WriteVarInt(ms, errorCode);
        }

        byte[] result = ms.ToArray();
        ms.Dispose();
        return result;
    }

    public static void Decode(byte[] data, out ulong context, out int errorCode)
    {
        context = 0;
        errorCode = 0;

        int pos = 0;
        while (pos + 4 <= data.Length)
        {
            // Read 4-byte Heat2 header: 3 bytes tag + 1 byte type
            uint tag = (uint)(data[pos] << 24 | data[pos + 1] << 16 | data[pos + 2] << 8);
            byte type = data[pos + 3];
            pos += 4;

            if (type == 0x00) // Integer
            {
                long value = ReadVarInt(data, ref pos);

                if (tag == 0x8EED3800) // CNTX
                    context = unchecked((ulong)value);
                else if (tag == 0x972CA300) // ERRC
                    errorCode = (int)value;
            }
            else
            {
                // Skip unknown fields — for robustness, break out
                // (a full implementation would skip based on type)
                break;
            }
        }
    }

    private static void WriteVarInt(Stream stream, long value)
    {
        if (value == 0)
        {
            stream.WriteByte(0);
            return;
        }

        byte curByte;
        if (value > 0)
            curByte = (byte)(value & 0x3F | 0x80);
        else
        {
            value = -value;
            curByte = (byte)(value & 0x3F | 0xC0);
        }

        for (long i = value >> 6; i > 0; i >>= 7)
        {
            stream.WriteByte(curByte);
            curByte = (byte)((i | 0x80) & 0xFF);
        }

        stream.WriteByte((byte)(curByte & 0x7F));
    }

    private static long ReadVarInt(byte[] data, ref int pos)
    {
        if (pos >= data.Length)
            return 0;

        byte first = data[pos++];
        if (first == 0)
            return 0;

        bool negative = (first & 0x40) != 0;
        long value = first & 0x3F;
        int shift = 6;

        if ((first & 0x80) != 0)
        {
            while (pos < data.Length)
            {
                byte b = data[pos++];
                value |= (long)(b & 0x7F) << shift;
                shift += 7;
                if ((b & 0x80) == 0)
                    break;
            }
        }

        return negative ? -value : value;
    }
}
