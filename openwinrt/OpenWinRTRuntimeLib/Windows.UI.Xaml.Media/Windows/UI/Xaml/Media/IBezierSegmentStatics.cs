namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Guid(0xc0287bac, 0x1410, 0x4530, 0x84, 0x52, 0x1c, 0x9d, 10, 0xd1, 0xf3, 0x41), ExclusiveTo(typeof(BezierSegment)), Version(0x6020000)]
    internal interface IBezierSegmentStatics
    {
        DependencyProperty Point1Property { get; }

        DependencyProperty Point2Property { get; }

        DependencyProperty Point3Property { get; }
    }
}

