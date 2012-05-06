namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [ExclusiveTo(typeof(RangeBaseAutomationPeer)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x827c7601, 0x3078, 0x4479, 0x95, 0xea, 0x91, 0x37, 0x4c, 160, 0x62, 7), WebHostHidden]
    internal interface IRangeBaseAutomationPeerFactory
    {
        RangeBaseAutomationPeer CreateInstanceWithOwner([In] RangeBase owner, [In] object outer, out object inner);
    }
}

