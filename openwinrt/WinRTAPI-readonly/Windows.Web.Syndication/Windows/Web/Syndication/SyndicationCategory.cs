namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Threading(ThreadingModel.Both), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Activatable(0x6020000), Activatable(typeof(ISyndicationCategoryFactory), 0x6020000)]
    public sealed class SyndicationCategory : ISyndicationCategory, ISyndicationNode
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SyndicationCategory();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SyndicationCategory([In] string term);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SyndicationCategory([In] string term, [In] string scheme, [In] string label);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public XmlDocument GetXmlDocument([In] SyndicationFormat format);

        public IVector<SyndicationAttribute> AttributeExtensions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri BaseUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<ISyndicationNode> ElementExtensions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Label { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Language { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string NodeName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string NodeNamespace { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string NodeValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Scheme { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Term { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Web.Syndication.ISyndicationCategory.Label { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Web.Syndication.ISyndicationCategory.Scheme { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Web.Syndication.ISyndicationCategory.Term { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<SyndicationAttribute> Windows.Web.Syndication.ISyndicationNode.AttributeExtensions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri Windows.Web.Syndication.ISyndicationNode.BaseUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<ISyndicationNode> Windows.Web.Syndication.ISyndicationNode.ElementExtensions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Web.Syndication.ISyndicationNode.Language { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Web.Syndication.ISyndicationNode.NodeName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Web.Syndication.ISyndicationNode.NodeNamespace { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Web.Syndication.ISyndicationNode.NodeValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

