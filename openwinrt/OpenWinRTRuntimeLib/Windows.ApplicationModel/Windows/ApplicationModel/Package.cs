namespace Windows.ApplicationModel
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Static(typeof(IPackageStatics), 0x6020000), Version(0x6020000), DualApiPartition(version=0x6020000), Threading(ThreadingModel.Both)]
    public sealed class Package : IPackage
    {
        public static Package Current { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<Package> Dependencies { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PackageId Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StorageFolder InstalledLocation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsFramework { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<Package> Windows.ApplicationModel.IPackage.Dependencies { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PackageId Windows.ApplicationModel.IPackage.Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StorageFolder Windows.ApplicationModel.IPackage.InstalledLocation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.ApplicationModel.IPackage.IsFramework { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

