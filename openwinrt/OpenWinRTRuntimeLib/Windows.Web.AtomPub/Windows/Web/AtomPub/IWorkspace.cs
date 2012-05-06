namespace Windows.Web.AtomPub
{
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Web.Syndication;

    [Version(0x6020000), ExclusiveTo(typeof(Workspace)), Guid(0xb41da63b, 0xa4b8, 0x4036, 0x89, 0xc5, 0x83, 0xc3, 0x12, 0x66, 0xba, 0x49)]
    internal interface IWorkspace : ISyndicationNode
    {
        IVectorView<ResourceCollection> Collections { get; }

        ISyndicationText Title { get; }
    }
}

