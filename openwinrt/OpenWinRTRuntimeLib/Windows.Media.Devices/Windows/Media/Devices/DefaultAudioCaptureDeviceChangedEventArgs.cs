namespace Windows.Media.Devices
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class DefaultAudioCaptureDeviceChangedEventArgs : IDefaultAudioDeviceChangedEventArgs
    {
        public string Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public AudioDeviceRole Role { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Media.Devices.IDefaultAudioDeviceChangedEventArgs.Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public AudioDeviceRole Windows.Media.Devices.IDefaultAudioDeviceChangedEventArgs.Role { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

