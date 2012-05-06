namespace Windows.Data.Xml.Dom
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x5cc5b382, 0xe6dd, 0x4991, 0xab, 0xef, 6, 0xd8, 210, 0xe7, 0xbd, 12)]
    public interface IXmlNodeSerializer
    {
        string GetXml();

        string InnerText { get; [param: In] set; }
    }
}

