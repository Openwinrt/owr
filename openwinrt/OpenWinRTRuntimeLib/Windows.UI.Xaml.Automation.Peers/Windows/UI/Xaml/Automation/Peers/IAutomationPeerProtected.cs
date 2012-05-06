namespace Windows.UI.Xaml.Automation.Peers
{
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation.Provider;

    [ExclusiveTo(typeof(AutomationPeer)), Windows.Foundation.Metadata.Guid(0xf4b40e52, 0x642f, 0x4629, 0xa5, 0x4a, 0xea, 0x5d, 0x23, 0x49, 0xc4, 0x48), Version(0x6020000), WebHostHidden]
    internal interface IAutomationPeerProtected
    {
        AutomationPeer GetPeerFromPoint([In] Point point);
        AutomationPeer PeerFromProvider([In] IRawElementProviderSimple provider);
        IRawElementProviderSimple ProviderFromPeer([In] AutomationPeer peer);
    }
}

