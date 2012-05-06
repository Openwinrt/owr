namespace Windows.UI.Xaml.Controls.Primitives
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), Guid(0xaf1eab12, 0x128, 0x4f67, 0x9c, 90, 130, 50, 12, 0x44, 0x5d, 0x19), WebHostHidden, ExclusiveTo(typeof(ToggleButton))]
    internal interface IToggleButtonStatics
    {
        DependencyProperty IsCheckedProperty { get; }

        DependencyProperty IsThreeStateProperty { get; }
    }
}

