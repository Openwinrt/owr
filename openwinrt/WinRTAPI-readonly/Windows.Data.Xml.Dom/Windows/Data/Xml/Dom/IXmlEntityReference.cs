namespace Windows.Data.Xml.Dom
{
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(XmlEntityReference)), Version(0x6020000), Guid(0x2e2f47bc, 0xc3d0, 0x4ccf, 0xbb, 0x86, 10, 0xb8, 0xc3, 0x6a, 0x61, 0xcf)]
    internal interface IXmlEntityReference : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
    {
    }
}

