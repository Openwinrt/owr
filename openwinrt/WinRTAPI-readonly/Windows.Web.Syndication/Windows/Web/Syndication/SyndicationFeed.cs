namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Activatable(0x6020000), DualApiPartition(version=0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Version(0x6020000), Activatable(typeof(ISyndicationFeedFactory), 0x6020000)]
    public sealed class SyndicationFeed : ISyndicationFeed, ISyndicationNode
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SyndicationFeed();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SyndicationFeed([In] string title, [In] string subtitle, [In] Uri uri);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public XmlDocument GetXmlDocument([In] SyndicationFormat format);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Load([In] string feed);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void LoadFromXml([In] XmlDocument feedDocument);

        public IVector<SyndicationAttribute> AttributeExtensions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<SyndicationPerson> Authors { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri BaseUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<SyndicationCategory> Categories { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<SyndicationPerson> Contributors { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<ISyndicationNode> ElementExtensions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri FirstUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SyndicationGenerator Generator { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Uri IconUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Uri ImageUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<SyndicationItem> Items { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Language { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Foundation.DateTime LastUpdatedTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Uri LastUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<SyndicationLink> Links { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri NextUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string NodeName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string NodeNamespace { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string NodeValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Uri PreviousUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ISyndicationText Rights { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public SyndicationFormat SourceFormat { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ISyndicationText Subtitle { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ISyndicationText Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<SyndicationPerson> Windows.Web.Syndication.ISyndicationFeed.Authors { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<SyndicationCategory> Windows.Web.Syndication.ISyndicationFeed.Categories { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<SyndicationPerson> Windows.Web.Syndication.ISyndicationFeed.Contributors { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri Windows.Web.Syndication.ISyndicationFeed.FirstUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SyndicationGenerator Windows.Web.Syndication.ISyndicationFeed.Generator { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Uri Windows.Web.Syndication.ISyndicationFeed.IconUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Web.Syndication.ISyndicationFeed.Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Uri Windows.Web.Syndication.ISyndicationFeed.ImageUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<SyndicationItem> Windows.Web.Syndication.ISyndicationFeed.Items { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.Web.Syndication.ISyndicationFeed.LastUpdatedTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Uri Windows.Web.Syndication.ISyndicationFeed.LastUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<SyndicationLink> Windows.Web.Syndication.ISyndicationFeed.Links { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri Windows.Web.Syndication.ISyndicationFeed.NextUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri Windows.Web.Syndication.ISyndicationFeed.PreviousUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ISyndicationText Windows.Web.Syndication.ISyndicationFeed.Rights { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public SyndicationFormat Windows.Web.Syndication.ISyndicationFeed.SourceFormat { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ISyndicationText Windows.Web.Syndication.ISyndicationFeed.Subtitle { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ISyndicationText Windows.Web.Syndication.ISyndicationFeed.Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<SyndicationAttribute> Windows.Web.Syndication.ISyndicationNode.AttributeExtensions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri Windows.Web.Syndication.ISyndicationNode.BaseUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<ISyndicationNode> Windows.Web.Syndication.ISyndicationNode.ElementExtensions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Web.Syndication.ISyndicationNode.Language { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Web.Syndication.ISyndicationNode.NodeName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Web.Syndication.ISyndicationNode.NodeNamespace { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Web.Syndication.ISyndicationNode.NodeValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

