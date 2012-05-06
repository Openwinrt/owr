namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Guid(0x9d9436f4, 0x40a7, 0x46dd, 0x97, 90, 7, 0xd3, 0x37, 0xcd, 0x85, 0x2e), ExclusiveTo(typeof(ScaleTransform)), Version(0x6020000), WebHostHidden]
    internal interface IScaleTransformStatics
    {
        DependencyProperty CenterXProperty { get; }

        DependencyProperty CenterYProperty { get; }

        DependencyProperty ScaleXProperty { get; }

        DependencyProperty ScaleYProperty { get; }
    }
}

