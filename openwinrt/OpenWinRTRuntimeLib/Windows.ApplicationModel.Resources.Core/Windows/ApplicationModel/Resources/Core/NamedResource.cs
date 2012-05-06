namespace Windows.ApplicationModel.Resources.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class NamedResource : INamedResource
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("Resolve")]
        public ResourceCandidate Resolve();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("ResolveForContext")]
        public ResourceCandidate Resolve([In] ResourceContext resourceContext);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("ResolveAll")]
        public IVectorView<ResourceCandidate> ResolveAll();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("ResolveAllForContext")]
        public IVectorView<ResourceCandidate> ResolveAll([In] ResourceContext resourceContext);

        public IVectorView<ResourceCandidate> Candidates { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.Uri Uri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<ResourceCandidate> Windows.ApplicationModel.Resources.Core.INamedResource.Candidates { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.Uri Windows.ApplicationModel.Resources.Core.INamedResource.Uri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

