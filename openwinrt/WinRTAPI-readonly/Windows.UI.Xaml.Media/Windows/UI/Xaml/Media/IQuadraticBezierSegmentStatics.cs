namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Guid(0x69c78278, 0x3c0b, 0x4b4f, 0xb7, 0xa2, 240, 3, 0xde, 0xd4, 0x1b, 0xb0), Version(0x6020000), ExclusiveTo(typeof(QuadraticBezierSegment)), WebHostHidden]
    internal interface IQuadraticBezierSegmentStatics
    {
        DependencyProperty Point1Property { get; }

        DependencyProperty Point2Property { get; }
    }
}

