namespace Windows.Storage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class ApplicationDataContainer : IApplicationDataContainer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ApplicationDataContainer CreateContainer([In] string name, [In] ApplicationDataCreateDisposition disposition);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void DeleteContainer([In] string name);

        public IMapView<string, ApplicationDataContainer> Containers { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ApplicationDataLocality Locality { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IPropertySet Values { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IMapView<string, ApplicationDataContainer> Windows.Storage.IApplicationDataContainer.Containers { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ApplicationDataLocality Windows.Storage.IApplicationDataContainer.Locality { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Storage.IApplicationDataContainer.Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IPropertySet Windows.Storage.IApplicationDataContainer.Values { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

