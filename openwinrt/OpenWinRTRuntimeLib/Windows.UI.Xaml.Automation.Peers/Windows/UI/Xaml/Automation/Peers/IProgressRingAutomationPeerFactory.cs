namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0xf3db204b, 0x157e, 0x40bc, 0x95, 0x93, 0x55, 0xbc, 0x5c, 0x71, 0xa4, 0xf6), ExclusiveTo(typeof(ProgressRingAutomationPeer))]
    internal interface IProgressRingAutomationPeerFactory
    {
        ProgressRingAutomationPeer CreateInstanceWithOwner([In] ProgressRing owner, [In] object outer, out object inner);
    }
}

