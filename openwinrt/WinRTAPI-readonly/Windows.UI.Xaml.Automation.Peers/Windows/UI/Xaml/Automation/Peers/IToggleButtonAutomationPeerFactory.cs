namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [Windows.Foundation.Metadata.Guid(0xc9218cc4, 0xad4b, 0x4d03, 0xa6, 0xa4, 0x7d, 0x59, 230, 0x36, 0, 4), WebHostHidden, ExclusiveTo(typeof(ToggleButtonAutomationPeer)), Version(0x6020000)]
    internal interface IToggleButtonAutomationPeerFactory
    {
        ToggleButtonAutomationPeer CreateInstanceWithOwner([In] ToggleButton owner, [In] object outer, out object inner);
    }
}

