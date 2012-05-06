namespace Windows.Management.Deployment
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.ApplicationModel;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(PackageManager)), Windows.Foundation.Metadata.Guid(0x9a7d4b65, 0x5e8f, 0x4fc7, 0xa2, 0xe5, 0x7f, 0x69, 0x25, 0xcb, 0x8b, 0x53)]
    internal interface IPackageManager
    {
        IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> AddPackageAsync([In] Uri packageUri, [In] IIterable<Uri> dependencyPackageUris, [In] DeploymentOptions deploymentOptions);
        IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> CleanupPackageForUserAsync([In] string packageName, [In] string userSid);
        [Overload("FindPackageByPackageFullName")]
        Package FindPackage([In] string packageFullName);
        [Overload("FindPackages")]
        IIterable<Package> FindPackages();
        [Overload("FindPackagesByNamePublisher")]
        IIterable<Package> FindPackages([In] string packageName, [In] string packagePublisher);
        [Overload("FindPackagesByUserSecurityId")]
        IIterable<Package> FindPackagesForUser([In] string userSecurityId);
        [Overload("FindPackagesByUserSecurityIdNamePublisher")]
        IIterable<Package> FindPackagesForUser([In] string userSecurityId, [In] string packageName, [In] string packagePublisher);
        IIterable<PackageUserInformation> FindUsers([In] string packageFullName);
        IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RegisterPackageAsync([In] Uri manifestUri, [In] IIterable<Uri> dependencyPackageUris, [In] DeploymentOptions deploymentOptions);
        IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RemovePackageAsync([In] string packageFullName);
        void SetPackageState([In] string packageFullName, [In] PackageState packageState);
        IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StagePackageAsync([In] Uri packageUri, [In] IIterable<Uri> dependencyPackageUris);
        IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> UpdatePackageAsync([In] Uri packageUri, [In] IIterable<Uri> dependencyPackageUris, [In] DeploymentOptions deploymentOptions);
    }
}

