namespace Windows.Management.Deployment
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class DeploymentResult : IDeploymentResult
    {
        public Guid ActivityId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string ErrorText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Guid Windows.Management.Deployment.IDeploymentResult.ActivityId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Management.Deployment.IDeploymentResult.ErrorText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

