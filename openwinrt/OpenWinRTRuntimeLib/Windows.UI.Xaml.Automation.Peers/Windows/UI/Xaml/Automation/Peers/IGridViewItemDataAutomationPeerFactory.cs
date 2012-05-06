namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0xa65e7a88, 0x770d, 0x402c, 0x99, 0x6f, 0x67, 80, 0x6a, 0xf2, 0xa4, 0xaf), ExclusiveTo(typeof(GridViewItemDataAutomationPeer))]
    internal interface IGridViewItemDataAutomationPeerFactory
    {
        GridViewItemDataAutomationPeer CreateInstanceWithParentAndItem([In] object item, [In] GridViewAutomationPeer parent, [In] object outer, out object inner);
    }
}

