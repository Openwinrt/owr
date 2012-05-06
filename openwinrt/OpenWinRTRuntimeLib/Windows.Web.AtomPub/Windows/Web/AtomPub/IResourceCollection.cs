namespace Windows.Web.AtomPub
{
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Web.Syndication;

    [Guid(0x7f5fd609, 0xbc88, 0x41d4, 0x88, 250, 0x3d, 230, 0x70, 0x4d, 0x42, 0x8e), Version(0x6020000), ExclusiveTo(typeof(ResourceCollection))]
    internal interface IResourceCollection : ISyndicationNode
    {
        IVectorView<string> Accepts { get; }

        IVectorView<SyndicationCategory> Categories { get; }

        ISyndicationText Title { get; }

        Windows.Foundation.Uri Uri { get; }
    }
}

