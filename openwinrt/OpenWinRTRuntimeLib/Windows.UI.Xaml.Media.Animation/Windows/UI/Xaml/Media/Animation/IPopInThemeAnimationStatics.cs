namespace Windows.UI.Xaml.Media.Animation
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), WebHostHidden, Guid(0xefaa99d3, 0x218a, 0x4701, 0x97, 0x7f, 0xf1, 0xbf, 0xae, 0x8b, 0xa6, 0x49), ExclusiveTo(typeof(PopInThemeAnimation))]
    internal interface IPopInThemeAnimationStatics
    {
        DependencyProperty FromHorizontalOffsetProperty { get; }

        DependencyProperty FromVerticalOffsetProperty { get; }

        DependencyProperty TargetNameProperty { get; }
    }
}

