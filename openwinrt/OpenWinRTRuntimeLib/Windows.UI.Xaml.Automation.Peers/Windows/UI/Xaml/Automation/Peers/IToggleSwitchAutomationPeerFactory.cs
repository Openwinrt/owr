namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Windows.Foundation.Metadata.Guid(0x31f933e3, 0xfef8, 0x4419, 0x9d, 0xf5, 0xd9, 0xef, 0x71, 150, 0xea, 0x34), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(ToggleSwitchAutomationPeer))]
    internal interface IToggleSwitchAutomationPeerFactory
    {
        ToggleSwitchAutomationPeer CreateInstanceWithOwner([In] ToggleSwitch owner, [In] object outer, out object inner);
    }
}

