namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Activatable(0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), DualApiPartition(version=0x6020000), Threading(ThreadingModel.Both), Activatable(typeof(ISyndicationItemFactory), 0x6020000)]
    public sealed class SyndicationItem : ISyndicationItem, ISyndicationNode
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SyndicationItem();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SyndicationItem([In] string title, [In] SyndicationContent content, [In] Uri uri);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public XmlDocument GetXmlDocument([In] SyndicationFormat format);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Load([In] string item);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void LoadFromXml([In] XmlDocument itemDocument);

        public IVector<SyndicationAttribute> AttributeExtensions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<SyndicationPerson> Authors { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri BaseUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<SyndicationCategory> Categories { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri CommentsUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public SyndicationContent Content { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<SyndicationPerson> Contributors { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri EditMediaUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri EditUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<ISyndicationNode> ElementExtensions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string ETag { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Uri ItemUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Language { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Foundation.DateTime LastUpdatedTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<SyndicationLink> Links { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string NodeName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string NodeNamespace { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string NodeValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Foundation.DateTime PublishedDate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ISyndicationText Rights { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public SyndicationFeed Source { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ISyndicationText Summary { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ISyndicationText Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<SyndicationPerson> Windows.Web.Syndication.ISyndicationItem.Authors { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<SyndicationCategory> Windows.Web.Syndication.ISyndicationItem.Categories { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri Windows.Web.Syndication.ISyndicationItem.CommentsUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public SyndicationContent Windows.Web.Syndication.ISyndicationItem.Content { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<SyndicationPerson> Windows.Web.Syndication.ISyndicationItem.Contributors { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri Windows.Web.Syndication.ISyndicationItem.EditMediaUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri Windows.Web.Syndication.ISyndicationItem.EditUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Web.Syndication.ISyndicationItem.ETag { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Web.Syndication.ISyndicationItem.Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Uri Windows.Web.Syndication.ISyndicationItem.ItemUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.Web.Syndication.ISyndicationItem.LastUpdatedTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<SyndicationLink> Windows.Web.Syndication.ISyndicationItem.Links { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.Web.Syndication.ISyndicationItem.PublishedDate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ISyndicationText Windows.Web.Syndication.ISyndicationItem.Rights { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public SyndicationFeed Windows.Web.Syndication.ISyndicationItem.Source { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ISyndicationText Windows.Web.Syndication.ISyndicationItem.Summary { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ISyndicationText Windows.Web.Syndication.ISyndicationItem.Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<SyndicationAttribute> Windows.Web.Syndication.ISyndicationNode.AttributeExtensions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri Windows.Web.Syndication.ISyndicationNode.BaseUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<ISyndicationNode> Windows.Web.Syndication.ISyndicationNode.ElementExtensions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Web.Syndication.ISyndicationNode.Language { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Web.Syndication.ISyndicationNode.NodeName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Web.Syndication.ISyndicationNode.NodeNamespace { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Web.Syndication.ISyndicationNode.NodeValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

