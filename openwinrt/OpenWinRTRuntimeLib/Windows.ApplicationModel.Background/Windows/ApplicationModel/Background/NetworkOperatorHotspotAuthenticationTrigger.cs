namespace Windows.ApplicationModel.Background
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Activatable(0x6020000)]
    public sealed class NetworkOperatorHotspotAuthenticationTrigger : INetworkOperatorHotspotAuthenticationTrigger, IBackgroundTrigger
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public NetworkOperatorHotspotAuthenticationTrigger();
    }
}

