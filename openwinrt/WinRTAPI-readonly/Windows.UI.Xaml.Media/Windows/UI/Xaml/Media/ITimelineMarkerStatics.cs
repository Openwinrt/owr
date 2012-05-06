namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(TimelineMarker)), Guid(0xc4aef0c6, 0x16a3, 0x484b, 0x87, 0xf5, 0x65, 40, 0xb8, 240, 0x4a, 0x47), WebHostHidden, Version(0x6020000)]
    internal interface ITimelineMarkerStatics
    {
        DependencyProperty TextProperty { get; }

        DependencyProperty TimeProperty { get; }

        DependencyProperty TypeProperty { get; }
    }
}

