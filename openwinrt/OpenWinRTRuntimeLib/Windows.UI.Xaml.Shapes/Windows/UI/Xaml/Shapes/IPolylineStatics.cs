namespace Windows.UI.Xaml.Shapes
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Version(0x6020000), Guid(0xc7aa2cd1, 0xa26c, 0x43b0, 170, 0xa5, 130, 0x2f, 0xa6, 0x4a, 0x11, 0xb9), ExclusiveTo(typeof(Polyline))]
    internal interface IPolylineStatics
    {
        DependencyProperty FillRuleProperty { get; }

        DependencyProperty PointsProperty { get; }
    }
}

