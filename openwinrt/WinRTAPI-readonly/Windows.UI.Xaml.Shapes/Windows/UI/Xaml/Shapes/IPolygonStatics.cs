namespace Windows.UI.Xaml.Shapes
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(Polygon)), Guid(0x362a8aab, 0xd463, 0x4366, 0x9e, 0x1a, 190, 0xba, 0x72, 0x81, 15, 0xb7)]
    internal interface IPolygonStatics
    {
        DependencyProperty FillRuleProperty { get; }

        DependencyProperty PointsProperty { get; }
    }
}

