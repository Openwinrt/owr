namespace Windows.Devices.Input
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x3a3f9b56, 0x6798, 0x4bbc, 0x83, 0x3e, 15, 0x34, 0xb1, 0x7c, 0x65, 0xff), Version(0x6020000), ExclusiveTo(typeof(KeyboardCapabilities))]
    internal interface IKeyboardCapabilities
    {
        int KeyboardPresent { get; }
    }
}

