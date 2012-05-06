namespace Windows.Web.AtomPub
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Web.Syndication;

    [Version(0x6020000), DualApiPartition(version=0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class ResourceCollection : IResourceCollection, ISyndicationNode
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public XmlDocument GetXmlDocument([In] SyndicationFormat format);

        public IVectorView<string> Accepts { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<SyndicationAttribute> AttributeExtensions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.Uri BaseUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVectorView<SyndicationCategory> Categories { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<ISyndicationNode> ElementExtensions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Language { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string NodeName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string NodeNamespace { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string NodeValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ISyndicationText Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.Uri Uri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<string> Windows.Web.AtomPub.IResourceCollection.Accepts { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<SyndicationCategory> Windows.Web.AtomPub.IResourceCollection.Categories { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ISyndicationText Windows.Web.AtomPub.IResourceCollection.Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.Uri Windows.Web.AtomPub.IResourceCollection.Uri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<SyndicationAttribute> Windows.Web.Syndication.ISyndicationNode.AttributeExtensions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.Uri Windows.Web.Syndication.ISyndicationNode.BaseUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<ISyndicationNode> Windows.Web.Syndication.ISyndicationNode.ElementExtensions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Web.Syndication.ISyndicationNode.Language { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Web.Syndication.ISyndicationNode.NodeName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Web.Syndication.ISyndicationNode.NodeNamespace { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Web.Syndication.ISyndicationNode.NodeValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

