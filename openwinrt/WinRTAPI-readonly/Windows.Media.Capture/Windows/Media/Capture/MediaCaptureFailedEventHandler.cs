namespace Windows.Media.Capture
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x2014effb, 0x5cd8, 0x4f08, 0xa3, 20, 13, 0x36, 13, 0xa5, 0x9f, 20)]
    public delegate void MediaCaptureFailedEventHandler([In] MediaCapture sender, [In] MediaCaptureFailedEventArgs errorEventArgs);
}

