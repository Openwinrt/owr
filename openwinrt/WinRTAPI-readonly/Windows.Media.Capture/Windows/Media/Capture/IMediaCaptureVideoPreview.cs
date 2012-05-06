namespace Windows.Media.Capture
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Media;
    using Windows.Media.MediaProperties;

    [ExclusiveTo(typeof(MediaCapture)), Windows.Foundation.Metadata.Guid(0x27727073, 0x549e, 0x447f, 0xa2, 10, 0x4f, 3, 0xc4, 0x79, 0xd8, 0xc0), WebHostHidden, Version(0x6020000)]
    internal interface IMediaCaptureVideoPreview
    {
        IAsyncAction StartPreviewAsync();
        [Overload("StartPreviewToCustomSinkAsync")]
        IAsyncAction StartPreviewToCustomSinkAsync([In] MediaEncodingProfile encodingProfile, [In] IMediaExtension customMediaSink);
        [Overload("StartPreviewToCustomSinkIdAsync")]
        IAsyncAction StartPreviewToCustomSinkAsync([In] MediaEncodingProfile encodingProfile, [In] string customSinkActivationId, [In] IPropertySet customSinkSettings);
        IAsyncAction StopPreviewAsync();
    }
}

