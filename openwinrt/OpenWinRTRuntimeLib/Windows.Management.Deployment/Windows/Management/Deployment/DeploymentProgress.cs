namespace Windows.Management.Deployment
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), Version(0x6020000)]
    public struct DeploymentProgress
    {
        public DeploymentProgressState state;
        public uint percentage;
    }
}

