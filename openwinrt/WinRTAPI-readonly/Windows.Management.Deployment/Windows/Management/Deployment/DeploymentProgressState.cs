namespace Windows.Management.Deployment
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum DeploymentProgressState
    {
        Queued,
        Processing
    }
}

