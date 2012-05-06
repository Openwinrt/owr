namespace Windows.UI.Xaml.Automation.Peers
{
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(FrameworkElementAutomationPeer)), WebHostHidden, Windows.Foundation.Metadata.Guid(0xb9c0b997, 0x2820, 0x44a1, 0xa5, 0xa8, 0x9b, 0x80, 30, 220, 0x26, 0x9e), Version(0x6020000)]
    internal interface IFrameworkElementAutomationPeerStatics
    {
        AutomationPeer CreatePeerForElement([In] UIElement element);
        AutomationPeer FromElement([In] UIElement element);
    }
}

