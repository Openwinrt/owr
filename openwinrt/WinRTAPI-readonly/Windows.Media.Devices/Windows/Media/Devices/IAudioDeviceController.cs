namespace Windows.Media.Devices
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xedd4a388, 0x79c7, 0x4f7c, 0x90, 0xe8, 0xef, 0x93, 0x4b, 0x21, 0x58, 10), Version(0x6020000), ExclusiveTo(typeof(AudioDeviceController))]
    internal interface IAudioDeviceController : IMediaDeviceController
    {
        bool Muted { get; [param: In] set; }

        float VolumePercent { get; [param: In] set; }
    }
}

