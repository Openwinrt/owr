namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, ExclusiveTo(typeof(PolyBezierSegment)), Version(0x6020000), Guid(0x1d91a6da, 0x1492, 0x4acc, 0xbd, 0x66, 0xa4, 150, 0xf3, 0xd8, 0x29, 0xd6)]
    internal interface IPolyBezierSegmentStatics
    {
        DependencyProperty PointsProperty { get; }
    }
}

