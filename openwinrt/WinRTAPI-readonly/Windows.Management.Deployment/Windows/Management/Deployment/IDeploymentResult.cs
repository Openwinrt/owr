namespace Windows.Management.Deployment
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x2563b9ae, 0xb77d, 0x4c1f, 0x8a, 0x7b, 0x20, 230, 0xad, 0x51, 0x5e, 0xf3), ExclusiveTo(typeof(DeploymentResult))]
    internal interface IDeploymentResult
    {
        Guid ActivityId { get; }

        string ErrorText { get; }
    }
}

