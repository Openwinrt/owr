namespace Windows.ApplicationModel
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.System;

    [DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class PackageId : IPackageId
    {
        public ProcessorArchitecture Architecture { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string FamilyName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string FullName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Publisher { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string PublisherId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string ResourceId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PackageVersion Version { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ProcessorArchitecture Windows.ApplicationModel.IPackageId.Architecture { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.IPackageId.FamilyName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.IPackageId.FullName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.IPackageId.Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.IPackageId.Publisher { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.IPackageId.PublisherId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.IPackageId.ResourceId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PackageVersion Windows.ApplicationModel.IPackageId.Version { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

