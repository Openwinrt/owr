namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xb9cc5e80, 0x313a, 0x4091, 0xa2, 0xa6, 0x24, 0x3e, 14, 0xe9, 0x23, 0xf9)]
    public interface ISyndicationText : ISyndicationNode
    {
        string ToString();

        string Text { get; [param: In] set; }

        string Type { get; [param: In] set; }

        XmlDocument Xml { get; [param: In] set; }
    }
}

