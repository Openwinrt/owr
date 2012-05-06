namespace Windows.UI.Xaml.Media.Animation
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Guid(0x324641b0, 0x7d37, 0x427a, 0xad, 0xeb, 0x43, 0xf3, 0x8b, 0xb6, 0x1a, 0x4d), Version(0x6020000), ExclusiveTo(typeof(DoubleKeyFrame)), WebHostHidden]
    internal interface IDoubleKeyFrameStatics
    {
        DependencyProperty KeyTimeProperty { get; }

        DependencyProperty ValueProperty { get; }
    }
}

