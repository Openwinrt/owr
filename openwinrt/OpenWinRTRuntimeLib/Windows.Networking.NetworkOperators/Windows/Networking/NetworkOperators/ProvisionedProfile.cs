namespace Windows.Networking.NetworkOperators
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Networking.Connectivity;

    [Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class ProvisionedProfile : IProvisionedProfile
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void UpdateCost([In] NetworkCostType value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void UpdateUsage([In] ProfileUsage value);
    }
}

