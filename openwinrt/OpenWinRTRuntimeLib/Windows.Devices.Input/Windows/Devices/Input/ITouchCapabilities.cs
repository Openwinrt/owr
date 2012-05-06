namespace Windows.Devices.Input
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x20dd55f9, 0x13f1, 0x46c8, 0x92, 0x85, 0x2c, 5, 250, 0x3e, 0xda, 0x6f), ExclusiveTo(typeof(TouchCapabilities)), Version(0x6020000)]
    internal interface ITouchCapabilities
    {
        uint Contacts { get; }

        int TouchPresent { get; }
    }
}

