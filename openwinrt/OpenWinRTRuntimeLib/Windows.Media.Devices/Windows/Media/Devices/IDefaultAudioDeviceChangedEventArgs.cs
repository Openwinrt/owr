namespace Windows.Media.Devices
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x110f882f, 0x1c05, 0x4657, 0xa1, 0x8e, 0x47, 0xc9, 0xb6, 0x9f, 7, 0xab), Version(0x6020000)]
    public interface IDefaultAudioDeviceChangedEventArgs
    {
        string Id { get; }

        AudioDeviceRole Role { get; }
    }
}

