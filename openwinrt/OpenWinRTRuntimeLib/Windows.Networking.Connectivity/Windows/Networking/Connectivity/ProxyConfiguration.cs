namespace Windows.Networking.Connectivity
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class ProxyConfiguration : IProxyConfiguration
    {
        public bool CanConnectDirectly { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<Uri> ProxyUris { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Networking.Connectivity.IProxyConfiguration.CanConnectDirectly { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<Uri> Windows.Networking.Connectivity.IProxyConfiguration.ProxyUris { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

