namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Guid(0x9fcab141, 0x4c0, 0x4afb, 0x87, 0xb3, 0xe8, 0, 0xb9, 0x69, 0xb8, 0x94), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(LineSegment))]
    internal interface ILineSegmentStatics
    {
        DependencyProperty PointProperty { get; }
    }
}

