namespace Windows.Devices.Enumeration
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum DeviceClass
    {
        All,
        AudioCapture,
        AudioRender,
        PortableStorageDevice,
        VideoCapture
    }
}

