namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(RotateTransform)), WebHostHidden, Version(0x6020000), Guid(0xa131eb8a, 0x51a3, 0x41b6, 0xb9, 0xd3, 0xa1, 14, 0x42, 0x90, 0x54, 0xab)]
    internal interface IRotateTransformStatics
    {
        DependencyProperty AngleProperty { get; }

        DependencyProperty CenterXProperty { get; }

        DependencyProperty CenterYProperty { get; }
    }
}

