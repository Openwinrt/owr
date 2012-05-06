namespace Windows.UI.Xaml.Media.Animation
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), ExclusiveTo(typeof(EntranceThemeTransition)), Guid(0x37cc0577, 0xff98, 0x4aed, 0xb8, 110, 0x5e, 0xc2, 0x37, 2, 0xf8, 0x77), WebHostHidden]
    internal interface IEntranceThemeTransitionStatics
    {
        DependencyProperty FromHorizontalOffsetProperty { get; }

        DependencyProperty FromVerticalOffsetProperty { get; }

        DependencyProperty IsStaggeringEnabledProperty { get; }
    }
}

