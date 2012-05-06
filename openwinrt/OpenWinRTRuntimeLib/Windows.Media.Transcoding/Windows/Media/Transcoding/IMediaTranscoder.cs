namespace Windows.Media.Transcoding
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Media.MediaProperties;
    using Windows.Storage;
    using Windows.Storage.Streams;

    [ExclusiveTo(typeof(MediaTranscoder)), Windows.Foundation.Metadata.Guid(0x190c99d2, 0xa0aa, 0x4d34, 0x86, 0xbc, 0xee, 0xd1, 0xb1, 0x2c, 0x2f, 0x5b), Version(0x6020000)]
    internal interface IMediaTranscoder
    {
        [Overload("AddAudioEffect")]
        void AddAudioEffect([In] string activatableClassId);
        [Overload("AddAudioEffectWithSettings")]
        void AddAudioEffect([In] string activatableClassId, [In] bool effectRequired, [In] IPropertySet configuration);
        [Overload("AddVideoEffect")]
        void AddVideoEffect([In] string activatableClassId);
        [Overload("AddVideoEffectWithSettings")]
        void AddVideoEffect([In] string activatableClassId, [In] bool effectRequired, [In] IPropertySet configuration);
        void ClearEffects();
        IAsyncOperation<PrepareTranscodeResult> PrepareFileTranscodeAsync([In] IStorageFile source, [In] IStorageFile destination, [In] MediaEncodingProfile profile);
        IAsyncOperation<PrepareTranscodeResult> PrepareStreamTranscodeAsync([In] IRandomAccessStream source, [In] IRandomAccessStream destination, [In] MediaEncodingProfile profile);

        bool AlwaysReencode { get; [param: In] set; }

        bool HardwareAccelerationEnabled { get; [param: In] set; }

        Windows.Foundation.TimeSpan TrimStartTime { get; [param: In] set; }

        Windows.Foundation.TimeSpan TrimStopTime { get; [param: In] set; }
    }
}

