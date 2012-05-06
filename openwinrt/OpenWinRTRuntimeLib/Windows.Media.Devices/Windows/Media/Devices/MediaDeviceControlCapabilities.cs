namespace Windows.Media.Devices
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class MediaDeviceControlCapabilities : IMediaDeviceControlCapabilities
    {
        public bool AutoModeSupported { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Default { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Max { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Min { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Step { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Supported { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Media.Devices.IMediaDeviceControlCapabilities.AutoModeSupported { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.Media.Devices.IMediaDeviceControlCapabilities.Default { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.Media.Devices.IMediaDeviceControlCapabilities.Max { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.Media.Devices.IMediaDeviceControlCapabilities.Min { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.Media.Devices.IMediaDeviceControlCapabilities.Step { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Media.Devices.IMediaDeviceControlCapabilities.Supported { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

