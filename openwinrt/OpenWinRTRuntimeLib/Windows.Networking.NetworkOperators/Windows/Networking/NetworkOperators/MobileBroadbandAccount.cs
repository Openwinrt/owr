namespace Windows.Networking.NetworkOperators
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), DualApiPartition(version=0x6020000), Static(typeof(IMobileBroadbandAccountStatics), 0x6020000), Threading(ThreadingModel.Both)]
    public sealed class MobileBroadbandAccount : IMobileBroadbandAccount
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static MobileBroadbandAccount CreateFromNetworkAccountId([In] string networkAccountId);

        public static IVectorView<string> AvailableNetworkAccountIds { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MobileBroadbandDeviceInformation CurrentDeviceInformation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MobileBroadbandNetwork CurrentNetwork { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string NetworkAccountId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Guid ServiceProviderGuid { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string ServiceProviderName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MobileBroadbandDeviceInformation Windows.Networking.NetworkOperators.IMobileBroadbandAccount.CurrentDeviceInformation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MobileBroadbandNetwork Windows.Networking.NetworkOperators.IMobileBroadbandAccount.CurrentNetwork { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.NetworkOperators.IMobileBroadbandAccount.NetworkAccountId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Guid Windows.Networking.NetworkOperators.IMobileBroadbandAccount.ServiceProviderGuid { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.NetworkOperators.IMobileBroadbandAccount.ServiceProviderName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

