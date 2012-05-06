namespace Windows.ApplicationModel
{
    using System;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [ExclusiveTo(typeof(Package)), Version(0x6020000), Guid(0x163c792f, 0xbd75, 0x413c, 0xbf, 0x23, 0xb1, 0xfe, 0x7b, 0x95, 0xd8, 0x25)]
    internal interface IPackage
    {
        IVectorView<Package> Dependencies { get; }

        PackageId Id { get; }

        StorageFolder InstalledLocation { get; }

        bool IsFramework { get; }
    }
}

