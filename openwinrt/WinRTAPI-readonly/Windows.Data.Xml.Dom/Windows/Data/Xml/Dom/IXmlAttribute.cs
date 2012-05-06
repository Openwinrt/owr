namespace Windows.Data.Xml.Dom
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(XmlAttribute)), Windows.Foundation.Metadata.Guid(0xac144aa4, 0xb4f1, 0x4db6, 0xb2, 6, 0x8a, 0x22, 0xc3, 8, 0xdb, 10)]
    internal interface IXmlAttribute : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
    {
        string Name { get; }

        bool Specified { get; }

        string Value { get; [param: In] set; }
    }
}

