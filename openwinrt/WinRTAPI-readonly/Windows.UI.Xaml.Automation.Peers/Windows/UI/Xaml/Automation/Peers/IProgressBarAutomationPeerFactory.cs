namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Windows.Foundation.Metadata.Guid(0x364679ab, 0xb80f, 0x41b4, 0x8e, 0xea, 0x2f, 0x52, 0x51, 0xbc, 0x73, 0x9c), Version(0x6020000), ExclusiveTo(typeof(ProgressBarAutomationPeer)), WebHostHidden]
    internal interface IProgressBarAutomationPeerFactory
    {
        ProgressBarAutomationPeer CreateInstanceWithOwner([In] ProgressBar owner, [In] object outer, out object inner);
    }
}

