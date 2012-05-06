namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [Windows.Foundation.Metadata.Guid(0x6a6ff9d4, 0x575e, 0x4e60, 0xbd, 0xd6, 0xec, 20, 0x41, 0x9b, 0x4f, 0xf6), Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(RepeatButtonAutomationPeer))]
    internal interface IRepeatButtonAutomationPeerFactory
    {
        RepeatButtonAutomationPeer CreateInstanceWithOwner([In] RepeatButton owner, [In] object outer, out object inner);
    }
}

