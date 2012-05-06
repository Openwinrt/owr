namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Activatable(0x6020000), WebHostHidden, Threading(ThreadingModel.Both)]
    public sealed class TimelineMarkerRoutedEventArgs : RoutedEventArgs, ITimelineMarkerRoutedEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public TimelineMarkerRoutedEventArgs();

        public TimelineMarker Marker { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public TimelineMarker Windows.UI.Xaml.Media.ITimelineMarkerRoutedEventArgs.Marker { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

