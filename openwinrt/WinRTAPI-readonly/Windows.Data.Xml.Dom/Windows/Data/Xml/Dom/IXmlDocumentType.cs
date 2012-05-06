namespace Windows.Data.Xml.Dom
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0xf7342425, 0x9781, 0x4964, 0x8e, 0x94, 0x9b, 0x1c, 0x6d, 0xfc, 0x9b, 0xc7), Version(0x6020000), ExclusiveTo(typeof(XmlDocumentType))]
    internal interface IXmlDocumentType : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
    {
        XmlNamedNodeMap Entities { get; }

        string Name { get; }

        XmlNamedNodeMap Notations { get; }
    }
}

