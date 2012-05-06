namespace Windows.Devices.Input
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(MouseCapabilities)), Version(0x6020000), Guid(0xbca5e023, 0x7dd9, 0x4b6b, 0x9a, 0x92, 0x55, 0xd4, 60, 0xb3, 0x8f, 0x73)]
    internal interface IMouseCapabilities
    {
        int HorizontalWheelPresent { get; }

        int MousePresent { get; }

        uint NumberOfButtons { get; }

        int SwapButtons { get; }

        int VerticalWheelPresent { get; }
    }
}

