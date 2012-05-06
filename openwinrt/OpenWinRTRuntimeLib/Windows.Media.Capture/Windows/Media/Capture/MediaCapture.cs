namespace Windows.Media.Capture
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Media;
    using Windows.Media.Devices;
    using Windows.Media.MediaProperties;
    using Windows.Storage;
    using Windows.Storage.Streams;

    [DualApiPartition(version=0x6020000), Threading(ThreadingModel.MTA), Version(0x6020000), Activatable(0x6020000)]
    public sealed class MediaCapture : IMediaCapture, IMediaCaptureVideoPreview
    {
        public event MediaCaptureFailedEventHandler Failed;

        public event MediaCaptureFailedEventHandler Windows.Media.Capture.IMediaCapture.Failed;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public MediaCapture();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction AddEffectAsync([In] MediaStreamType mediaStreamType, [In] string effectActivationID, [In] IPropertySet effectSettings);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction CapturePhotoToStorageFileAsync([In] ImageEncodingProperties type, [In] IStorageFile file);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction CapturePhotoToStreamAsync([In] ImageEncodingProperties type, [In] IRandomAccessStream stream);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction ClearEffectsAsync([In] MediaStreamType mediaStreamType);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public object GetEncoderProperty([In] MediaStreamType mediaStreamType, [In] Guid propertyId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool GetPreviewMirroring();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public VideoRotation GetPreviewRotation();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public VideoRotation GetRecordRotation();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("InitializeAsync")]
        public IAsyncAction InitializeAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("InitializeWithSettingsAsync")]
        public IAsyncAction InitializeAsync([In] MediaCaptureInitializationSettings mediaCaptureInitializationSettings);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetEncoderProperty([In] MediaStreamType mediaStreamType, [In] Guid propertyId, [In] object propertyValue);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetPreviewMirroring([In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetPreviewRotation([In] VideoRotation value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetRecordRotation([In] VideoRotation value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction StartPreviewAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("StartPreviewToCustomSinkAsync")]
        public IAsyncAction StartPreviewToCustomSinkAsync([In] MediaEncodingProfile encodingProfile, [In] IMediaExtension customMediaSink);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("StartPreviewToCustomSinkIdAsync")]
        public IAsyncAction StartPreviewToCustomSinkAsync([In] MediaEncodingProfile encodingProfile, [In] string customSinkActivationId, [In] IPropertySet customSinkSettings);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("StartRecordToCustomSinkAsync")]
        public IAsyncAction StartRecordToCustomSinkAsync([In] MediaEncodingProfile encodingProfile, [In] IMediaExtension customMediaSink);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("StartRecordToCustomSinkIdAsync")]
        public IAsyncAction StartRecordToCustomSinkAsync([In] MediaEncodingProfile encodingProfile, [In] string customSinkActivationId, [In] IPropertySet customSinkSettings);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction StartRecordToStorageFileAsync([In] MediaEncodingProfile encodingProfile, [In] IStorageFile file);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction StartRecordToStreamAsync([In] MediaEncodingProfile encodingProfile, [In] IRandomAccessStream stream);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction StopPreviewAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction StopRecordAsync();

        public Windows.Media.Devices.AudioDeviceController AudioDeviceController { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Media.Capture.MediaCaptureSettings MediaCaptureSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Media.Devices.VideoDeviceController VideoDeviceController { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Media.Devices.AudioDeviceController Windows.Media.Capture.IMediaCapture.AudioDeviceController { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Media.Capture.MediaCaptureSettings Windows.Media.Capture.IMediaCapture.MediaCaptureSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Media.Devices.VideoDeviceController Windows.Media.Capture.IMediaCapture.VideoDeviceController { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

