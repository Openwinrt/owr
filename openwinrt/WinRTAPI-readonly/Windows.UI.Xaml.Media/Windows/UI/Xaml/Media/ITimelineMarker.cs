namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xa68ef02d, 0x45ba, 0x4e50, 140, 0xad, 170, 0xea, 0x3a, 0x22, 0x7a, 0xf5), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(TimelineMarker))]
    internal interface ITimelineMarker
    {
        string Text { get; [param: In] set; }

        Windows.Foundation.TimeSpan Time { get; [param: In] set; }

        string Type { get; [param: In] set; }
    }
}

