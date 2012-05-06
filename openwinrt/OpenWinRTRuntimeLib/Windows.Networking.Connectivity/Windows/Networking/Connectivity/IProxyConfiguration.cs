namespace Windows.Networking.Connectivity
{
    using System;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0xef3a60b4, 0x9004, 0x4dd6, 0xb7, 0xd8, 0xb3, 0xe5, 2, 0xf4, 170, 0xd0), ExclusiveTo(typeof(ProxyConfiguration))]
    internal interface IProxyConfiguration
    {
        bool CanConnectDirectly { get; }

        IVectorView<Uri> ProxyUris { get; }
    }
}

