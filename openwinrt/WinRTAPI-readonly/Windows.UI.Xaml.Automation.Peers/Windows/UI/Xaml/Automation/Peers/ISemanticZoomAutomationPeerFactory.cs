namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xf518d44d, 0xa493, 0x4496, 0xb0, 0x77, 150, 0x74, 0xc7, 0xf4, 0xc5, 250), ExclusiveTo(typeof(SemanticZoomAutomationPeer)), WebHostHidden]
    internal interface ISemanticZoomAutomationPeerFactory
    {
        SemanticZoomAutomationPeer CreateInstanceWithOwner([In] SemanticZoom owner, [In] object outer, out object inner);
    }
}

