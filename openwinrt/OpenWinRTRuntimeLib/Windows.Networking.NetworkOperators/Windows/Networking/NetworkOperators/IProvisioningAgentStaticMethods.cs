namespace Windows.Networking.NetworkOperators
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ProvisioningAgent)), Windows.Foundation.Metadata.Guid(0x217700e0, 0x8101, 0x11df, 0xad, 0xb9, 0xf4, 0xce, 70, 0x2d, 0x91, 0x37), Version(0x6020000)]
    internal interface IProvisioningAgentStaticMethods
    {
        ProvisioningAgent CreateFromNetworkAccountId([In] string networkAccountId);
    }
}

