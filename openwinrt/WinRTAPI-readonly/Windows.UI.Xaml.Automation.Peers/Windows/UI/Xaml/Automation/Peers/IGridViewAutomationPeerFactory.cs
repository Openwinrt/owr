namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Windows.Foundation.Metadata.Guid(0x8aca59dd, 0x22a7, 0x4800, 0x89, 0x4b, 0xc1, 0xf4, 0x85, 0xf3, 0x89, 0x53), WebHostHidden, ExclusiveTo(typeof(GridViewAutomationPeer)), Version(0x6020000)]
    internal interface IGridViewAutomationPeerFactory
    {
        GridViewAutomationPeer CreateInstanceWithOwner([In] GridView owner, [In] object outer, out object inner);
    }
}

