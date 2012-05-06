namespace Windows.Media.Devices
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Version(0x6020000), Static(typeof(IMediaDeviceStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public static class MediaDevice
    {
        public static  event TypedEventHandler<object, DefaultAudioCaptureDeviceChangedEventArgs> DefaultAudioCaptureDeviceChanged;

        public static  event TypedEventHandler<object, DefaultAudioRenderDeviceChangedEventArgs> DefaultAudioRenderDeviceChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string GetAudioCaptureSelector();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string GetAudioRenderSelector();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string GetDefaultAudioCaptureId([In] AudioDeviceRole role);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string GetDefaultAudioRenderId([In] AudioDeviceRole role);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string GetVideoCaptureSelector();
    }
}

