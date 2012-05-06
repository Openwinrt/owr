namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Windows.Foundation.Metadata.Guid(0x70d3c2be, 0x8950, 0x4647, 0x93, 0x62, 0xfd, 0, 0x2f, 0x8f, 0xf8, 0x2e), ExclusiveTo(typeof(ListViewBaseAutomationPeer)), Version(0x6020000), WebHostHidden]
    internal interface IListViewBaseAutomationPeerFactory
    {
        ListViewBaseAutomationPeer CreateInstanceWithOwner([In] ListViewBase owner, [In] object outer, out object inner);
    }
}

