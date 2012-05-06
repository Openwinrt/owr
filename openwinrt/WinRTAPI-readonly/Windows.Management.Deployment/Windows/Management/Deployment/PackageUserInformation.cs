namespace Windows.Management.Deployment
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class PackageUserInformation : IPackageUserInformation
    {
        public PackageInstallState InstallState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string UserSecurityId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PackageInstallState Windows.Management.Deployment.IPackageUserInformation.InstallState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Management.Deployment.IPackageUserInformation.UserSecurityId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

