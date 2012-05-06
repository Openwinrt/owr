namespace Windows.ApplicationModel.Resources.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Static(typeof(IResourceContextStatics), 0x6020000), Version(0x6020000), Activatable(0x6020000), Threading(ThreadingModel.MTA)]
    public sealed class ResourceContext : IResourceContext
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ResourceContext();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ResourceContext Clone();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static ResourceContext CreateMatchingContext([In] IIterable<ResourceQualifier> result);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void OverrideToMatch([In] IIterable<ResourceQualifier> result);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("Reset")]
        public void Reset();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("ResetQualifierValues")]
        public void Reset([In] IIterable<string> qualifierNames);

        public IVectorView<string> Languages { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IObservableMap<string, string> QualifierValues { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<string> Windows.ApplicationModel.Resources.Core.IResourceContext.Languages { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IObservableMap<string, string> Windows.ApplicationModel.Resources.Core.IResourceContext.QualifierValues { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

