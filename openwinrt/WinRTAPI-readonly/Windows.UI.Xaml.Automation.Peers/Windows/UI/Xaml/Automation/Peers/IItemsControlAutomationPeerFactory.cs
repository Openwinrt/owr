namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [ExclusiveTo(typeof(ItemsControlAutomationPeer)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x4038a259, 0x2e1a, 0x49ca, 0xa5, 0x33, 0xc6, 0x4f, 0x18, 0x15, 0x77, 230), WebHostHidden]
    internal interface IItemsControlAutomationPeerFactory
    {
        ItemsControlAutomationPeer CreateInstanceWithOwner([In] ItemsControl owner, [In] object outer, out object inner);
    }
}

