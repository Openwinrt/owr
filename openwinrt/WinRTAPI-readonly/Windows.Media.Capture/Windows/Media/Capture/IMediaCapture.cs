namespace Windows.Media.Capture
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Media;
    using Windows.Media.Devices;
    using Windows.Media.MediaProperties;
    using Windows.Storage;
    using Windows.Storage.Streams;

    [Windows.Foundation.Metadata.Guid(0xc61afbb4, 0xfb10, 0x4a34, 0xac, 0x18, 0xca, 0x80, 0xd9, 200, 0xe7, 0xee), ExclusiveTo(typeof(MediaCapture)), Version(0x6020000)]
    internal interface IMediaCapture
    {
        event MediaCaptureFailedEventHandler Failed;

        IAsyncAction AddEffectAsync([In] MediaStreamType mediaStreamType, [In] string effectActivationID, [In] IPropertySet effectSettings);
        IAsyncAction CapturePhotoToStorageFileAsync([In] ImageEncodingProperties type, [In] IStorageFile file);
        IAsyncAction CapturePhotoToStreamAsync([In] ImageEncodingProperties type, [In] IRandomAccessStream stream);
        IAsyncAction ClearEffectsAsync([In] MediaStreamType mediaStreamType);
        object GetEncoderProperty([In] MediaStreamType mediaStreamType, [In] Guid propertyId);
        bool GetPreviewMirroring();
        VideoRotation GetPreviewRotation();
        VideoRotation GetRecordRotation();
        [Overload("InitializeAsync")]
        IAsyncAction InitializeAsync();
        [Overload("InitializeWithSettingsAsync")]
        IAsyncAction InitializeAsync([In] MediaCaptureInitializationSettings mediaCaptureInitializationSettings);
        void SetEncoderProperty([In] MediaStreamType mediaStreamType, [In] Guid propertyId, [In] object propertyValue);
        void SetPreviewMirroring([In] bool value);
        void SetPreviewRotation([In] VideoRotation value);
        void SetRecordRotation([In] VideoRotation value);
        [Overload("StartRecordToCustomSinkAsync")]
        IAsyncAction StartRecordToCustomSinkAsync([In] MediaEncodingProfile encodingProfile, [In] IMediaExtension customMediaSink);
        [Overload("StartRecordToCustomSinkIdAsync")]
        IAsyncAction StartRecordToCustomSinkAsync([In] MediaEncodingProfile encodingProfile, [In] string customSinkActivationId, [In] IPropertySet customSinkSettings);
        IAsyncAction StartRecordToStorageFileAsync([In] MediaEncodingProfile encodingProfile, [In] IStorageFile file);
        IAsyncAction StartRecordToStreamAsync([In] MediaEncodingProfile encodingProfile, [In] IRandomAccessStream stream);
        IAsyncAction StopRecordAsync();

        Windows.Media.Devices.AudioDeviceController AudioDeviceController { get; }

        Windows.Media.Capture.MediaCaptureSettings MediaCaptureSettings { get; }

        Windows.Media.Devices.VideoDeviceController VideoDeviceController { get; }
    }
}

