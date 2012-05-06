namespace Windows.Data.Xml.Dom
{
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(XmlComment)), Version(0x6020000), Guid(0xbca474d5, 0xb61f, 0x4611, 0x9c, 0xac, 0x2e, 0x92, 0xe3, 0x47, 0x6d, 0x47)]
    internal interface IXmlComment : IXmlCharacterData, IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
    {
    }
}

