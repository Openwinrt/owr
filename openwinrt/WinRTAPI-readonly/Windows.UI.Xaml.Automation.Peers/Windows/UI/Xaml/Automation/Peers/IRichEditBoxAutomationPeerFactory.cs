namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [ExclusiveTo(typeof(RichEditBoxAutomationPeer)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x752c8399, 0xd296, 0x4d87, 0x90, 0x20, 0xa4, 0x75, 14, 0x88, 0x5b, 60), WebHostHidden]
    internal interface IRichEditBoxAutomationPeerFactory
    {
        RichEditBoxAutomationPeer CreateInstanceWithOwner([In] RichEditBox owner, [In] object outer, out object inner);
    }
}

