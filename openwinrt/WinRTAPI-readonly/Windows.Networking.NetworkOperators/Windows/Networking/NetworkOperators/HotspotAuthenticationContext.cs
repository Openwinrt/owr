namespace Windows.Networking.NetworkOperators
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Networking.Connectivity;

    [Version(0x6020000), Static(typeof(IHotspotAuthenticationContextStatics), 0x6020000), Threading(ThreadingModel.Both)]
    public sealed class HotspotAuthenticationContext : IHotspotAuthenticationContext
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void AbortAuthentication([In] bool markAsManual);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void IssueCredentials([In] string userName, [In] string password, [In] string extraParameters, [In] bool markAsManualConnectOnFailure);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SkipAuthentication();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void TriggerAttentionRequired([In] string packageRelativeApplicationId, [In] string applicationParameters);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool TryGetAuthenticationContext([In] string evenToken, out HotspotAuthenticationContext context);

        public Uri AuthenticationUrl { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Networking.Connectivity.NetworkAdapter NetworkAdapter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri RedirectMessageUrl { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public XmlDocument RedirectMessageXml { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri Windows.Networking.NetworkOperators.IHotspotAuthenticationContext.AuthenticationUrl { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Networking.Connectivity.NetworkAdapter Windows.Networking.NetworkOperators.IHotspotAuthenticationContext.NetworkAdapter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri Windows.Networking.NetworkOperators.IHotspotAuthenticationContext.RedirectMessageUrl { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public XmlDocument Windows.Networking.NetworkOperators.IHotspotAuthenticationContext.RedirectMessageXml { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public byte[] Windows.Networking.NetworkOperators.IHotspotAuthenticationContext.WirelessNetworkId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public byte[] WirelessNetworkId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

