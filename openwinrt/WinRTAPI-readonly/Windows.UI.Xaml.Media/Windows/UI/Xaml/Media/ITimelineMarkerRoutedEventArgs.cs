namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, ExclusiveTo(typeof(TimelineMarkerRoutedEventArgs)), Windows.Foundation.Metadata.Guid(0x7c3b3ef3, 0x2c88, 0x4d9c, 0x99, 0xb6, 70, 0xcd, 0xbd, 0x48, 0xd4, 0xc1), Version(0x6020000)]
    internal interface ITimelineMarkerRoutedEventArgs
    {
        TimelineMarker Marker { get; [param: In] set; }
    }
}

