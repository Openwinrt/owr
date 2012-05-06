namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0xd0db12bb, 0xd715, 0x4523, 0xac, 0xc0, 30, 0x10, 0x72, 0xd8, 0xe3, 0x2b), Version(0x6020000), ExclusiveTo(typeof(ListViewItemDataAutomationPeer))]
    internal interface IListViewItemDataAutomationPeerFactory
    {
        ListViewItemDataAutomationPeer CreateInstanceWithParentAndItem([In] object item, [In] ListViewBaseAutomationPeer parent, [In] object outer, out object inner);
    }
}

