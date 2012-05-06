namespace Windows.Networking.NetworkOperators
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Networking.Connectivity;

    [Windows.Foundation.Metadata.Guid(0xe756c791, 0x1003, 0x4de5, 0x83, 0xc7, 0xde, 0x61, 0xd8, 0x88, 0x31, 0xd0), ExclusiveTo(typeof(HotspotAuthenticationContext)), Version(0x6020000)]
    internal interface IHotspotAuthenticationContext
    {
        void AbortAuthentication([In] bool markAsManual);
        void IssueCredentials([In] string userName, [In] string password, [In] string extraParameters, [In] bool markAsManualConnectOnFailure);
        void SkipAuthentication();
        void TriggerAttentionRequired([In] string packageRelativeApplicationId, [In] string applicationParameters);

        Uri AuthenticationUrl { get; }

        Windows.Networking.Connectivity.NetworkAdapter NetworkAdapter { get; }

        Uri RedirectMessageUrl { get; }

        XmlDocument RedirectMessageXml { get; }

        byte[] WirelessNetworkId { get; }
    }
}

