namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x29065073, 0xde3d, 0x4d3f, 0x97, 180, 0x4d, 0x6f, 0x9d, 0x53, 0x44, 0x4d), ExclusiveTo(typeof(ItemAutomationPeer)), Version(0x6020000), WebHostHidden]
    internal interface IItemAutomationPeerFactory
    {
        ItemAutomationPeer CreateInstanceWithParentAndItem([In] object item, [In] ItemsControlAutomationPeer parent, [In] object outer, out object inner);
    }
}

