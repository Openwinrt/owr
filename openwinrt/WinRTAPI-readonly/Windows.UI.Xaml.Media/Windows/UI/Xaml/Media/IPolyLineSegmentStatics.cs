namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, ExclusiveTo(typeof(PolyLineSegment)), Guid(0xd64a2c87, 0x33f1, 0x4e70, 0xa4, 0x7f, 180, 0x98, 30, 0xf6, 0x48, 0xa2), Version(0x6020000)]
    internal interface IPolyLineSegmentStatics
    {
        DependencyProperty PointsProperty { get; }
    }
}

