namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), ExclusiveTo(typeof(ToggleSwitch)), WebHostHidden, Guid(0x1d37147f, 0x97df, 0x4226, 0x92, 0xca, 0xdd, 0xf4, 0x53, 0xd7, 0xfd, 90)]
    internal interface IToggleSwitchStatics
    {
        DependencyProperty HeaderProperty { get; }

        DependencyProperty HeaderTemplateProperty { get; }

        DependencyProperty IsOnProperty { get; }

        DependencyProperty OffContentProperty { get; }

        DependencyProperty OffContentTemplateProperty { get; }

        DependencyProperty OnContentProperty { get; }

        DependencyProperty OnContentTemplateProperty { get; }
    }
}

