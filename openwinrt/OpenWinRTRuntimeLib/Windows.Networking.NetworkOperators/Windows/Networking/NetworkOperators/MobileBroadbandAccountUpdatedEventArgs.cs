namespace Windows.Networking.NetworkOperators
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class MobileBroadbandAccountUpdatedEventArgs : IMobileBroadbandAccountUpdatedEventArgs
    {
        public bool HasDeviceInformationChanged { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool HasNetworkChanged { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string NetworkAccountId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Networking.NetworkOperators.IMobileBroadbandAccountUpdatedEventArgs.HasDeviceInformationChanged { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Networking.NetworkOperators.IMobileBroadbandAccountUpdatedEventArgs.HasNetworkChanged { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.NetworkOperators.IMobileBroadbandAccountUpdatedEventArgs.NetworkAccountId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

