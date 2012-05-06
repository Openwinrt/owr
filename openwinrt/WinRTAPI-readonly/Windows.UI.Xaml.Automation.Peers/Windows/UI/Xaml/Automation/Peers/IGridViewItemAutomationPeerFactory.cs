namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0xfafec376, 0xf22e, 0x466d, 0x91, 60, 0xae, 0x24, 0xcc, 0xdb, 0x16, 15), Version(0x6020000), ExclusiveTo(typeof(GridViewItemAutomationPeer))]
    internal interface IGridViewItemAutomationPeerFactory
    {
        GridViewItemAutomationPeer CreateInstanceWithOwner([In] GridViewItem owner, [In] object outer, out object inner);
    }
}

