namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(ScrollViewerAutomationPeer)), Windows.Foundation.Metadata.Guid(0x270dff7d, 0xd96d, 0x48f9, 0xa3, 0x6a, 0xc2, 0x52, 170, 0x9c, 70, 0x70)]
    internal interface IScrollViewerAutomationPeerFactory
    {
        ScrollViewerAutomationPeer CreateInstanceWithOwner([In] ScrollViewer owner, [In] object outer, out object inner);
    }
}

