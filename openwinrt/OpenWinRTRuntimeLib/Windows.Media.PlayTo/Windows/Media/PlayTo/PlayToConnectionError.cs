namespace Windows.Media.PlayTo
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum PlayToConnectionError
    {
        None,
        DeviceNotResponding,
        DeviceError
    }
}

