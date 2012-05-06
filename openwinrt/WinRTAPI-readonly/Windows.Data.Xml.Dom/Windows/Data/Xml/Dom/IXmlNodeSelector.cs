namespace Windows.Data.Xml.Dom
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x63dbba8b, 0xd0db, 0x4fe1, 0xb7, 0x45, 0xf9, 0x43, 0x3a, 0xfd, 0xc2, 0x5b)]
    public interface IXmlNodeSelector
    {
        XmlNodeList SelectNodes([In] string xpath);
        XmlNodeList SelectNodesNS([In] string xpath, [In, Variant] object namespaces);
        IXmlNode SelectSingleNode([In] string xpath);
        IXmlNode SelectSingleNodeNS([In] string xpath, [In, Variant] object namespaces);
    }
}

