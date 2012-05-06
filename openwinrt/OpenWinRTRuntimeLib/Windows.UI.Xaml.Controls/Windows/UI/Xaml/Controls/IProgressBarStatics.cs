namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), Guid(0x7a129fda, 0x5837, 0x4e26, 0xb3, 180, 0xe1, 0xc0, 0x92, 0xce, 0xbb, 0xec), ExclusiveTo(typeof(ProgressBar)), WebHostHidden]
    internal interface IProgressBarStatics
    {
        DependencyProperty IsIndeterminateProperty { get; }

        DependencyProperty ShowErrorProperty { get; }

        DependencyProperty ShowPausedProperty { get; }
    }
}

