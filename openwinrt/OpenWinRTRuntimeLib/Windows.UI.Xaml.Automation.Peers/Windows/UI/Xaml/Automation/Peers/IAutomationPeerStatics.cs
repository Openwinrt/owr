namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0x562f7fb0, 0xa331, 0x4a9c, 0x9d, 0xec, 0xbf, 0xb7, 0x58, 0x6f, 0xff, 0xff), Version(0x6020000), ExclusiveTo(typeof(AutomationPeer))]
    internal interface IAutomationPeerStatics
    {
        bool ListenerExists([In] AutomationEvents eventId);
    }
}

