namespace Windows.Management.Deployment
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0xf6383423, 0xfa09, 0x4cbc, 0x90, 0x55, 0x15, 0xca, 0x27, 0x5e, 0x2e, 0x7e), ExclusiveTo(typeof(PackageUserInformation)), Version(0x6020000)]
    internal interface IPackageUserInformation
    {
        PackageInstallState InstallState { get; }

        string UserSecurityId { get; }
    }
}

