namespace Windows.ApplicationModel.Resources.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class ResourceCandidate : IResourceCandidate
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string GetQualifierValue([In] string qualifierName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<StorageFile> ToFileAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string ToString();

        public bool IsDefault { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsMatch { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsMatchAsDefault { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<ResourceQualifier> Qualifiers { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.ApplicationModel.Resources.Core.IResourceCandidate.IsDefault { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.ApplicationModel.Resources.Core.IResourceCandidate.IsMatch { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.ApplicationModel.Resources.Core.IResourceCandidate.IsMatchAsDefault { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<ResourceQualifier> Windows.ApplicationModel.Resources.Core.IResourceCandidate.Qualifiers { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

