namespace Windows.Networking.NetworkOperators
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class MobileBroadbandAccountEventArgs : IMobileBroadbandAccountEventArgs
    {
        public string NetworkAccountId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.NetworkOperators.IMobileBroadbandAccountEventArgs.NetworkAccountId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

