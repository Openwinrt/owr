namespace Windows.Data.Xml.Dom
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class XmlDomImplementation : IXmlDomImplementation
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool HasFeature([In] string feature, [In, Variant] object version);
    }
}

