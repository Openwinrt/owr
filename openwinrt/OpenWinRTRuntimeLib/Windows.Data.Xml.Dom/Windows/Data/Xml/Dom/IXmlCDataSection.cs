namespace Windows.Data.Xml.Dom
{
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(XmlCDataSection)), Guid(0x4d04b46f, 0xc8bd, 0x45b4, 0x88, 0x99, 4, 0, 0xd7, 0xc2, 0xc6, 15), Version(0x6020000)]
    internal interface IXmlCDataSection : IXmlText, IXmlCharacterData, IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
    {
    }
}

