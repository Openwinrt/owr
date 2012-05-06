namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Windows.Foundation.Metadata.Guid(0xdb9b8bc, 0xb812, 0x48e3, 0xaf, 0x1f, 0xdb, 0xc5, 0x76, 0, 0xc3, 0x25), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(FrameworkElementAutomationPeer))]
    internal interface IFrameworkElementAutomationPeerFactory
    {
        FrameworkElementAutomationPeer CreateInstanceWithOwner([In] FrameworkElement owner, [In] object outer, out object inner);
    }
}

