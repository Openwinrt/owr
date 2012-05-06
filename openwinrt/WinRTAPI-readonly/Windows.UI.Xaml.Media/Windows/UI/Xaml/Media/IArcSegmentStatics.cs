namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Guid(0x82348f6e, 0x8a69, 0x4204, 0x9c, 0x12, 0x72, 7, 0xdf, 0x31, 0x76, 0x43), ExclusiveTo(typeof(ArcSegment)), Version(0x6020000)]
    internal interface IArcSegmentStatics
    {
        DependencyProperty IsLargeArcProperty { get; }

        DependencyProperty PointProperty { get; }

        DependencyProperty RotationAngleProperty { get; }

        DependencyProperty SizeProperty { get; }

        DependencyProperty SweepDirectionProperty { get; }
    }
}

