namespace Windows.Networking.NetworkOperators
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Networking.Connectivity;

    [Version(0x6020000), ExclusiveTo(typeof(ProvisionedProfile)), Windows.Foundation.Metadata.Guid(0x217700e0, 0x8202, 0x11df, 0xad, 0xb9, 0xf4, 0xce, 70, 0x2d, 0x91, 0x37)]
    internal interface IProvisionedProfile
    {
        void UpdateCost([In] NetworkCostType value);
        void UpdateUsage([In] ProfileUsage value);
    }
}

