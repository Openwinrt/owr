namespace Windows.Media.Devices
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x23005816, 0xeb85, 0x43e2, 0xb9, 0x2b, 130, 0x40, 0xd5, 0xee, 0x70, 0xec), Version(0x6020000), ExclusiveTo(typeof(MediaDeviceControlCapabilities))]
    internal interface IMediaDeviceControlCapabilities
    {
        bool AutoModeSupported { get; }

        double Default { get; }

        double Max { get; }

        double Min { get; }

        double Step { get; }

        bool Supported { get; }
    }
}

