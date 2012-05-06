namespace Windows.ApplicationModel.Activation
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0xfb67a508, 0x2dad, 0x490a, 0x91, 0x70, 220, 160, 0x36, 0xeb, 0x11, 0x4b)]
    public interface ICameraSettingsActivatedEventArgs : IActivatedEventArgs
    {
        object VideoDeviceController { get; }

        object VideoDeviceExtension { get; }
    }
}

