namespace Windows.Web.AtomPub
{
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Web.Syndication;

    [Guid(0x8b7ec771, 0x2ab3, 0x4dbe, 0x8b, 0xcc, 0x77, 0x8f, 0x92, 0xb7, 0x5e, 0x51), ExclusiveTo(typeof(ServiceDocument)), Version(0x6020000)]
    internal interface IServiceDocument : ISyndicationNode
    {
        IVectorView<Workspace> Workspaces { get; }
    }
}

