namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x971b8056, 0x9a7a, 0x4df9, 0x95, 250, 0x6f, 0x5c, 4, 0xc9, 0x1c, 0xac), ExclusiveTo(typeof(SliderAutomationPeer))]
    internal interface ISliderAutomationPeerFactory
    {
        SliderAutomationPeer CreateInstanceWithOwner([In] Slider owner, [In] object outer, out object inner);
    }
}

