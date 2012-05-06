namespace Windows.Data.Xml.Dom
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x6de58132, 0xf11d, 0x4fbb, 140, 0xc6, 0x58, 60, 0xba, 0x93, 0x11, 0x2f), Version(0x6020000), ExclusiveTo(typeof(XmlDomImplementation))]
    internal interface IXmlDomImplementation
    {
        bool HasFeature([In] string feature, [In, Variant] object version);
    }
}

