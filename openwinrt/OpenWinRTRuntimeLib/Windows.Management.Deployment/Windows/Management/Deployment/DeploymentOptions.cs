namespace Windows.Management.Deployment
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Flags]
    public enum DeploymentOptions : uint
    {
        DevelopmentMode = 2,
        ForceApplicationShutdown = 1,
        None = 0
    }
}

