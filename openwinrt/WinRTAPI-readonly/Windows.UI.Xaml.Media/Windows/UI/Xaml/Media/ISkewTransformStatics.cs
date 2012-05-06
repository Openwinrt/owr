namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(SkewTransform)), WebHostHidden, Guid(0xecd11d73, 0x5614, 0x4b31, 0xb6, 0xaf, 190, 0xae, 0x10, 0x10, 0x56, 0x24), Version(0x6020000)]
    internal interface ISkewTransformStatics
    {
        DependencyProperty AngleXProperty { get; }

        DependencyProperty AngleYProperty { get; }

        DependencyProperty CenterXProperty { get; }

        DependencyProperty CenterYProperty { get; }
    }
}

