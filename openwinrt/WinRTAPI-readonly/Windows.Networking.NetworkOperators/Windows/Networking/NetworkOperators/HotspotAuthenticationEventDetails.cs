namespace Windows.Networking.NetworkOperators
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class HotspotAuthenticationEventDetails : IHotspotAuthenticationEventDetails
    {
        public string EventToken { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.NetworkOperators.IHotspotAuthenticationEventDetails.EventToken { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

