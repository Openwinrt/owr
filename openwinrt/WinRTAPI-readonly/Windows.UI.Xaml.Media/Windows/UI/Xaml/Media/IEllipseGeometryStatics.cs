namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Guid(0x1744db47, 0xf635, 0x4b16, 0xae, 230, 0xe0, 0x52, 0xa6, 0x5d, 0xef, 0xb2), ExclusiveTo(typeof(EllipseGeometry)), Version(0x6020000)]
    internal interface IEllipseGeometryStatics
    {
        DependencyProperty CenterProperty { get; }

        DependencyProperty RadiusXProperty { get; }

        DependencyProperty RadiusYProperty { get; }
    }
}

