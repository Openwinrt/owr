namespace Windows.Management.Deployment
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.ApplicationModel;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Version(0x6020000), Activatable(0x6020000)]
    public sealed class PackageManager : IPackageManager
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PackageManager();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> AddPackageAsync([In] Uri packageUri, [In] IIterable<Uri> dependencyPackageUris, [In] DeploymentOptions deploymentOptions);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> CleanupPackageForUserAsync([In] string packageName, [In] string userSid);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("FindPackageByPackageFullName")]
        public Package FindPackage([In] string packageFullName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("FindPackages")]
        public IIterable<Package> FindPackages();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("FindPackagesByNamePublisher")]
        public IIterable<Package> FindPackages([In] string packageName, [In] string packagePublisher);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("FindPackagesByUserSecurityId")]
        public IIterable<Package> FindPackagesForUser([In] string userSecurityId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("FindPackagesByUserSecurityIdNamePublisher")]
        public IIterable<Package> FindPackagesForUser([In] string userSecurityId, [In] string packageName, [In] string packagePublisher);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IIterable<PackageUserInformation> FindUsers([In] string packageFullName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RegisterPackageAsync([In] Uri manifestUri, [In] IIterable<Uri> dependencyPackageUris, [In] DeploymentOptions deploymentOptions);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RemovePackageAsync([In] string packageFullName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetPackageState([In] string packageFullName, [In] PackageState packageState);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StagePackageAsync([In] Uri packageUri, [In] IIterable<Uri> dependencyPackageUris);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> UpdatePackageAsync([In] Uri packageUri, [In] IIterable<Uri> dependencyPackageUris, [In] DeploymentOptions deploymentOptions);
    }
}

