namespace Windows.UI.Xaml.Media.Animation
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(SplinePointKeyFrame)), WebHostHidden, Version(0x6020000), Guid(0xe97a32c2, 0xa7a, 0x4766, 0x95, 0xcb, 13, 0x69, 0x26, 0x11, 0xcb, 0x4c)]
    internal interface ISplinePointKeyFrameStatics
    {
        DependencyProperty KeySplineProperty { get; }
    }
}

