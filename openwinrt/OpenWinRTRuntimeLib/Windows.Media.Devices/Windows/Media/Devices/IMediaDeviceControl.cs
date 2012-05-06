namespace Windows.Media.Devices
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xefa8dfa9, 0x6f75, 0x4863, 0xba, 11, 0x58, 0x3f, 0x30, 0x36, 180, 0xde), ExclusiveTo(typeof(MediaDeviceControl)), Version(0x6020000)]
    internal interface IMediaDeviceControl
    {
        bool TryGetAuto(out bool value);
        bool TryGetValue(out double value);
        bool TrySetAuto([In] bool value);
        bool TrySetValue([In] double value);

        MediaDeviceControlCapabilities Capabilities { get; }
    }
}

