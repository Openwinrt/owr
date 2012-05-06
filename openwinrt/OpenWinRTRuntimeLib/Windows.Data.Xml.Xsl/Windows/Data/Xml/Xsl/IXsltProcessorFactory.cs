namespace Windows.Data.Xml.Xsl
{
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x274146c0, 0x9a51, 0x4663, 0xbf, 0x30, 14, 0xf7, 0x42, 20, 0x6f, 0x20), Version(0x6020000), ExclusiveTo(typeof(XsltProcessor))]
    internal interface IXsltProcessorFactory
    {
        XsltProcessor CreateInstance([In] XmlDocument document);
    }
}

