namespace Windows.Data.Xml.Dom
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(XmlNamedNodeMap)), Windows.Foundation.Metadata.Guid(0xb3a69eb0, 0xaab0, 0x4b82, 0xa6, 250, 0xb1, 0x45, 0x3f, 0x7c, 2, 0x1b)]
    internal interface IXmlNamedNodeMap : IVectorView<IXmlNode>, IIterable<IXmlNode>
    {
        IXmlNode GetNamedItem([In] string name);
        IXmlNode GetNamedItemNS([In, Variant] object namespaceUri, [In] string name);
        IXmlNode Item([In] uint index);
        IXmlNode RemoveNamedItem([In] string name);
        IXmlNode RemoveNamedItemNS([In, Variant] object namespaceUri, [In] string name);
        IXmlNode SetNamedItem([In] IXmlNode node);
        IXmlNode SetNamedItemNS([In] IXmlNode node);

        uint Length { get; }
    }
}

