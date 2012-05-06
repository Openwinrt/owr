namespace Windows.UI.Xaml.Automation.Peers
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), ExclusiveTo(typeof(FrameworkElementAutomationPeer)), Guid(0xb90ad781, 0xbfeb, 0x4451, 0xbd, 0x47, 0x9f, 0x3a, 0x63, 0xeb, 210, 0x4a), WebHostHidden]
    internal interface IFrameworkElementAutomationPeer
    {
        UIElement Owner { get; }
    }
}

