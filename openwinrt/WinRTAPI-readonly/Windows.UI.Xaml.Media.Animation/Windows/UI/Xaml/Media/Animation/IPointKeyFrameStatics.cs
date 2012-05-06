namespace Windows.UI.Xaml.Media.Animation
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Guid(0x95cf1b27, 0x7965, 0x4bec, 0xb9, 0xfb, 0xfb, 0xe9, 0x4b, 0x65, 0x51, 0x8e), Version(0x6020000), ExclusiveTo(typeof(PointKeyFrame))]
    internal interface IPointKeyFrameStatics
    {
        DependencyProperty KeyTimeProperty { get; }

        DependencyProperty ValueProperty { get; }
    }
}

