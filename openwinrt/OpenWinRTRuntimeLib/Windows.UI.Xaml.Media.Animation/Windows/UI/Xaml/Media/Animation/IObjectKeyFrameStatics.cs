namespace Windows.UI.Xaml.Media.Animation
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(ObjectKeyFrame)), WebHostHidden, Guid(0x2cd6ab00, 0x5319, 0x4286, 0x8e, 0xed, 0x4e, 0x75, 0x5e, 160, 0xcf, 0x9c), Version(0x6020000)]
    internal interface IObjectKeyFrameStatics
    {
        DependencyProperty KeyTimeProperty { get; }

        DependencyProperty ValueProperty { get; }
    }
}

