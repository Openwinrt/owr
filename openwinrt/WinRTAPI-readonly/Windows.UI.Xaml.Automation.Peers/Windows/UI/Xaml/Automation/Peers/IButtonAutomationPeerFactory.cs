namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [ExclusiveTo(typeof(ButtonAutomationPeer)), WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0x3fdb9f49, 0xf4ab, 0x4780, 0x86, 0x44, 3, 0x37, 0x62, 0x99, 0xa1, 0x75)]
    internal interface IButtonAutomationPeerFactory
    {
        ButtonAutomationPeer CreateInstanceWithOwner([In] Button owner, [In] object outer, out object inner);
    }
}

