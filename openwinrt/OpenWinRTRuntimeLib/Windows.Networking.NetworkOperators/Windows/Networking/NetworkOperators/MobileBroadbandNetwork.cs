namespace Windows.Networking.NetworkOperators
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.Networking.Connectivity;

    [Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class MobileBroadbandNetwork : IMobileBroadbandNetwork
    {
        public string AccessPointName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint ActivationNetworkError { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Networking.Connectivity.NetworkAdapter NetworkAdapter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Networking.NetworkOperators.NetworkRegistrationState NetworkRegistrationState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint PacketAttachNetworkError { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint RegistrationNetworkError { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.NetworkOperators.IMobileBroadbandNetwork.AccessPointName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Networking.NetworkOperators.IMobileBroadbandNetwork.ActivationNetworkError { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Networking.Connectivity.NetworkAdapter Windows.Networking.NetworkOperators.IMobileBroadbandNetwork.NetworkAdapter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Networking.NetworkOperators.NetworkRegistrationState Windows.Networking.NetworkOperators.IMobileBroadbandNetwork.NetworkRegistrationState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Networking.NetworkOperators.IMobileBroadbandNetwork.PacketAttachNetworkError { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Networking.NetworkOperators.IMobileBroadbandNetwork.RegistrationNetworkError { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

