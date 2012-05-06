namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0x8a04091e, 0xe6b2, 0x4c60, 0xa7, 0x59, 0xc1, 60, 0xa4, 0x51, 0x65, 0xed), ExclusiveTo(typeof(ButtonBaseAutomationPeer))]
    internal interface IButtonBaseAutomationPeerFactory
    {
        ButtonBaseAutomationPeer CreateInstanceWithOwner([In] ButtonBase owner, [In] object outer, out object inner);
    }
}

