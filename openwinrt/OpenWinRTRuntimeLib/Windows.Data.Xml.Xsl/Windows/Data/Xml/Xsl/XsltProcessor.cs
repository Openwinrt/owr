namespace Windows.Data.Xml.Xsl
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Activatable(typeof(IXsltProcessorFactory), 0x6020000)]
    public sealed class XsltProcessor : IXsltProcessor
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public XsltProcessor([In] XmlDocument document);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string TransformToString([In] IXmlNode inputNode);
    }
}

