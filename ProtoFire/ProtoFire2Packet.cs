using ProtoFire.Frames;

namespace ProtoFire;

/// <summary>
/// Fire2 packet: 16-byte header + metadata + payload.
/// Metadata is Heat2-encoded Fire2Metadata TDF (contains error code, context, etc.).
/// Data is the Heat2-encoded TDF payload.
/// </summary>
public class ProtoFire2Packet : ProtoFirePacket
{
    public byte[] MetadataData { get; set; }

    public new Fire2Frame Frame => (Fire2Frame)base.Frame;

    public ProtoFire2Packet(Fire2Frame frame, byte[] metadataData, byte[] data)
        : base(frame, data)
    {
        MetadataData = metadataData;
    }

    public static ProtoFire2Packet? ReadFrom(Stream stream)
    {
        try
        {
            Fire2Frame frame = new Fire2Frame();
            frame.Initialize(stream);

            byte[] metadataData = Array.Empty<byte>();
            if (frame.MetadataSize > 0)
            {
                metadataData = new byte[frame.MetadataSize];
                stream.ReadExactly(metadataData, 0, frame.MetadataSize);
            }

            byte[] data = Array.Empty<byte>();
            if (frame.PayloadSize > 0)
            {
                data = new byte[frame.PayloadSize];
                stream.ReadExactly(data, 0, (int)frame.PayloadSize);
            }

            return new ProtoFire2Packet(frame, metadataData, data);
        }
        catch (Exception)
        {
            return null;
        }
    }

    public static async Task<ProtoFire2Packet?> ReadFromAsync(Stream stream)
    {
        try
        {
            Fire2Frame frame = new Fire2Frame();
            await frame.InitializeAsync(stream).ConfigureAwait(false);

            byte[] metadataData = Array.Empty<byte>();
            if (frame.MetadataSize > 0)
            {
                metadataData = new byte[frame.MetadataSize];
                await stream.ReadExactlyAsync(metadataData, 0, frame.MetadataSize).ConfigureAwait(false);
            }

            byte[] data = Array.Empty<byte>();
            if (frame.PayloadSize > 0)
            {
                data = new byte[frame.PayloadSize];
                await stream.ReadExactlyAsync(data, 0, (int)frame.PayloadSize).ConfigureAwait(false);
            }

            return new ProtoFire2Packet(frame, metadataData, data);
        }
        catch (Exception)
        {
            return null;
        }
    }

    public new void WriteTo(Stream stream)
    {
        Frame.PayloadSize = (uint)Data.Length;
        Frame.MetadataSize = (ushort)MetadataData.Length;

        Frame.WriteTo(stream);

        if (MetadataData.Length > 0)
            stream.Write(MetadataData, 0, MetadataData.Length);

        if (Data.Length > 0)
            stream.Write(Data, 0, Data.Length);
    }

    public new async Task WriteToAsync(Stream stream)
    {
        Frame.PayloadSize = (uint)Data.Length;
        Frame.MetadataSize = (ushort)MetadataData.Length;

        await Frame.WriteToAsync(stream).ConfigureAwait(false);

        if (MetadataData.Length > 0)
            await stream.WriteAsync(MetadataData, 0, MetadataData.Length).ConfigureAwait(false);

        if (Data.Length > 0)
            await stream.WriteAsync(Data, 0, Data.Length).ConfigureAwait(false);
    }
}
