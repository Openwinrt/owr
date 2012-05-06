namespace Windows.UI.Xaml.Media.Animation
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Guid(0xc043ae99, 0x210c, 0x430f, 0x9d, 0xa5, 0xdf, 0x10, 130, 0x69, 0x20, 0x55), WebHostHidden, ExclusiveTo(typeof(ColorKeyFrame)), Version(0x6020000)]
    internal interface IColorKeyFrameStatics
    {
        DependencyProperty KeyTimeProperty { get; }

        DependencyProperty ValueProperty { get; }
    }
}

