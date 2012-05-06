namespace Windows.ApplicationModel.Resources.Core
{
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x1c98c219, 0xb13, 0x4240, 0x89, 0xa5, 0xd4, 0x95, 220, 0x18, 0x9a, 0), Version(0x6020000), ExclusiveTo(typeof(NamedResource))]
    internal interface INamedResource
    {
        [Overload("Resolve")]
        ResourceCandidate Resolve();
        [Overload("ResolveForContext")]
        ResourceCandidate Resolve([In] ResourceContext resourceContext);
        [Overload("ResolveAll")]
        IVectorView<ResourceCandidate> ResolveAll();
        [Overload("ResolveAllForContext")]
        IVectorView<ResourceCandidate> ResolveAll([In] ResourceContext resourceContext);

        IVectorView<ResourceCandidate> Candidates { get; }

        Windows.Foundation.Uri Uri { get; }
    }
}

