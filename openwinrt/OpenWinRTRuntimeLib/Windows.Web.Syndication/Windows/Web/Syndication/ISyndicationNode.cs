namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x753cef78, 0x51f8, 0x45c0, 0xa9, 0xf5, 0xf1, 0x71, 0x9d, 0xec, 0x3f, 0xb2)]
    public interface ISyndicationNode
    {
        XmlDocument GetXmlDocument([In] SyndicationFormat format);

        IVector<SyndicationAttribute> AttributeExtensions { get; }

        Uri BaseUri { get; [param: In] set; }

        IVector<ISyndicationNode> ElementExtensions { get; }

        string Language { get; [param: In] set; }

        string NodeName { get; [param: In] set; }

        string NodeNamespace { get; [param: In] set; }

        string NodeValue { get; [param: In] set; }
    }
}

