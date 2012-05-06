namespace Windows.Data.Xml.Xsl
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x7b64703f, 0x550c, 0x48c6, 0xa9, 15, 0x93, 0xa5, 0xb9, 100, 0x51, 0x8f), ExclusiveTo(typeof(XsltProcessor)), Version(0x6020000)]
    internal interface IXsltProcessor
    {
        string TransformToString([In] IXmlNode inputNode);
    }
}

