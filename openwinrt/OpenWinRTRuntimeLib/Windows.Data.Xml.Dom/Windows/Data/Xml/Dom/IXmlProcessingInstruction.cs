namespace Windows.Data.Xml.Dom
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(XmlProcessingInstruction)), Windows.Foundation.Metadata.Guid(0x2707fd1e, 0x1e92, 0x4ece, 0xb6, 0xf4, 0x26, 240, 0x69, 7, 0x8d, 220), Version(0x6020000)]
    internal interface IXmlProcessingInstruction : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
    {
        string Data { get; [param: In] set; }

        string Target { get; }
    }
}

