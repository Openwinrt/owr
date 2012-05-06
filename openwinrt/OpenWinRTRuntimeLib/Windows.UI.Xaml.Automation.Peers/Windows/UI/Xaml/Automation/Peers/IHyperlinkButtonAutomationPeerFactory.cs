namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [ExclusiveTo(typeof(HyperlinkButtonAutomationPeer)), WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0x59bc1661, 0xc182, 0x49af, 0x95, 0x26, 0x44, 0xb8, 0x8e, 0x62, 0x84, 0x55)]
    internal interface IHyperlinkButtonAutomationPeerFactory
    {
        HyperlinkButtonAutomationPeer CreateInstanceWithOwner([In] HyperlinkButton owner, [In] object outer, out object inner);
    }
}

