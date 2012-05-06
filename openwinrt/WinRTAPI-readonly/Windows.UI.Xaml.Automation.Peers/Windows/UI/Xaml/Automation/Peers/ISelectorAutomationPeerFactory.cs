namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [Windows.Foundation.Metadata.Guid(0x7b525646, 0x829b, 0x4dcc, 0xbd, 0x52, 90, 0x8d, 3, 0x99, 0x38, 0x7a), Version(0x6020000), ExclusiveTo(typeof(SelectorAutomationPeer)), WebHostHidden]
    internal interface ISelectorAutomationPeerFactory
    {
        SelectorAutomationPeer CreateInstanceWithOwner([In] Selector owner, [In] object outer, out object inner);
    }
}

