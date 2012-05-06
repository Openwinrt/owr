namespace Windows.Networking.Proximity
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class PeerInformation : IPeerInformation
    {
        public string DisplayName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.Proximity.IPeerInformation.DisplayName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

