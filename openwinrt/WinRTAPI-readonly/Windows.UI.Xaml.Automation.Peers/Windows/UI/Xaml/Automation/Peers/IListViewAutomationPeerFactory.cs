namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0x65f39174, 0xeaa2, 0x4e44, 0x8b, 230, 0x4c, 0xca, 40, 0xcd, 2, 0x88), ExclusiveTo(typeof(ListViewAutomationPeer))]
    internal interface IListViewAutomationPeerFactory
    {
        ListViewAutomationPeer CreateInstanceWithOwner([In] ListView owner, [In] object outer, out object inner);
    }
}

