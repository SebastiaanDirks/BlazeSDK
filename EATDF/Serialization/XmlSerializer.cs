using EATDF.Visitors;

namespace EATDF.Serialization;

public class XmlSerializer : TdfSerializer
{
    public override string Name => "Xml";

    public override bool Deserialize(Stream stream, Tdf tdf)
    {
        XmlDecoder decoder = new XmlDecoder(stream);
        decoder.VisitTdf(tdf);
        return decoder.Success;
    }

    public override void Serialize(Stream stream, Tdf tdf)
    {
        XmlEncoder encoder = new XmlEncoder(stream);
        encoder.VisitTdf(tdf);
    }
}
