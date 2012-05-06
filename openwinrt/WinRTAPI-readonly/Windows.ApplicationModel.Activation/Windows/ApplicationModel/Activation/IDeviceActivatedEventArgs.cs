namespace Windows.ApplicationModel.Activation
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0xcd50b9a9, 0xce10, 0x44d2, 130, 0x34, 0xc3, 0x55, 160, 0x73, 0xef, 0x33), Version(0x6020000)]
    public interface IDeviceActivatedEventArgs : IActivatedEventArgs
    {
        string DeviceInformationId { get; }

        string Verb { get; }
    }
}

