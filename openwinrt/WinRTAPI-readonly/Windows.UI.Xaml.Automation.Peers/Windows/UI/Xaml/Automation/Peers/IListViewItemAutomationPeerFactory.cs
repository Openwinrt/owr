namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0xc47dfbc0, 0xfacc, 0x4024, 0xa7, 0x3b, 0x17, 0xec, 0x4e, 0x66, 0x26, 0x54), ExclusiveTo(typeof(ListViewItemAutomationPeer)), Version(0x6020000)]
    internal interface IListViewItemAutomationPeerFactory
    {
        ListViewItemAutomationPeer CreateInstanceWithOwner([In] ListViewItem owner, [In] object outer, out object inner);
    }
}

