namespace Windows.Media.Devices
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class MediaDeviceControl : IMediaDeviceControl
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool TryGetAuto(out bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool TryGetValue(out double value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool TrySetAuto([In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool TrySetValue([In] double value);

        public MediaDeviceControlCapabilities Capabilities { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaDeviceControlCapabilities Windows.Media.Devices.IMediaDeviceControl.Capabilities { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

