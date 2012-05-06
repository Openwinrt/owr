namespace Windows.Media.Devices
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xaa2d9a40, 0x909f, 0x4bba, 0xbf, 0x8b, 12, 13, 0x29, 0x6f, 20, 240), Version(0x6020000), ExclusiveTo(typeof(MediaDevice))]
    internal interface IMediaDeviceStatics
    {
        event TypedEventHandler<object, DefaultAudioCaptureDeviceChangedEventArgs> DefaultAudioCaptureDeviceChanged;

        event TypedEventHandler<object, DefaultAudioRenderDeviceChangedEventArgs> DefaultAudioRenderDeviceChanged;

        string GetAudioCaptureSelector();
        string GetAudioRenderSelector();
        string GetDefaultAudioCaptureId([In] AudioDeviceRole role);
        string GetDefaultAudioRenderId([In] AudioDeviceRole role);
        string GetVideoCaptureSelector();
    }
}

