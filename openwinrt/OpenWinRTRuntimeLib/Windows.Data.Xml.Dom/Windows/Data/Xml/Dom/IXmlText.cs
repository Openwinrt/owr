namespace Windows.Data.Xml.Dom
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xf931a4cb, 0x308d, 0x4760, 0xa1, 0xd5, 0x43, 0xb6, 0x74, 80, 0xac, 0x7e), Version(0x6020000)]
    public interface IXmlText : IXmlCharacterData, IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
    {
        IXmlText SplitText([In] uint offset);
    }
}

