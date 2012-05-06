namespace Windows.ApplicationModel.Resources.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xf744d97b, 0x9988, 0x44fb, 0xab, 0xd6, 0x53, 120, 0x84, 0x4c, 250, 0x8b), ExclusiveTo(typeof(ResourceManager))]
    internal interface IResourceManager
    {
        void LoadPriFiles([In] IIterable<IStorageFile> files);
        void UnloadPriFiles([In] IIterable<IStorageFile> files);

        IMapView<string, ResourceMap> AllResourceMaps { get; }

        ResourceContext DefaultContext { get; }

        ResourceMap MainResourceMap { get; }
    }
}

