namespace Windows.ApplicationModel.Resources.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Static(typeof(IResourceManagerStatics), 0x6020000), Threading(ThreadingModel.MTA), Version(0x6020000)]
    public sealed class ResourceManager : IResourceManager
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool IsResourceReference([In] string resourceReference);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void LoadPriFiles([In] IIterable<IStorageFile> files);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void UnloadPriFiles([In] IIterable<IStorageFile> files);

        public IMapView<string, ResourceMap> AllResourceMaps { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static ResourceManager Current { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ResourceContext DefaultContext { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ResourceMap MainResourceMap { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IMapView<string, ResourceMap> Windows.ApplicationModel.Resources.Core.IResourceManager.AllResourceMaps { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ResourceContext Windows.ApplicationModel.Resources.Core.IResourceManager.DefaultContext { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ResourceMap Windows.ApplicationModel.Resources.Core.IResourceManager.MainResourceMap { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

