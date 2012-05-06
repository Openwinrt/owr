namespace Windows.Media.Transcoding
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Media.MediaProperties;
    using Windows.Storage;
    using Windows.Storage.Streams;

    [Version(0x6020000), Activatable(0x6020000), DualApiPartition(version=0x6020000), Threading(ThreadingModel.MTA)]
    public sealed class MediaTranscoder : IMediaTranscoder
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public MediaTranscoder();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("AddAudioEffect")]
        public void AddAudioEffect([In] string activatableClassId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("AddAudioEffectWithSettings")]
        public void AddAudioEffect([In] string activatableClassId, [In] bool effectRequired, [In] IPropertySet configuration);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("AddVideoEffect")]
        public void AddVideoEffect([In] string activatableClassId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("AddVideoEffectWithSettings")]
        public void AddVideoEffect([In] string activatableClassId, [In] bool effectRequired, [In] IPropertySet configuration);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ClearEffects();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<PrepareTranscodeResult> PrepareFileTranscodeAsync([In] IStorageFile source, [In] IStorageFile destination, [In] MediaEncodingProfile profile);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<PrepareTranscodeResult> PrepareStreamTranscodeAsync([In] IRandomAccessStream source, [In] IRandomAccessStream destination, [In] MediaEncodingProfile profile);

        public bool AlwaysReencode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool HardwareAccelerationEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Foundation.TimeSpan TrimStartTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Foundation.TimeSpan TrimStopTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.Media.Transcoding.IMediaTranscoder.AlwaysReencode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.Media.Transcoding.IMediaTranscoder.HardwareAccelerationEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Foundation.TimeSpan Windows.Media.Transcoding.IMediaTranscoder.TrimStartTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Foundation.TimeSpan Windows.Media.Transcoding.IMediaTranscoder.TrimStopTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

