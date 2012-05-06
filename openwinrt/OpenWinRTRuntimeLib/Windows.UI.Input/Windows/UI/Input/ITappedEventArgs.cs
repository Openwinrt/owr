namespace Windows.UI.Input
{
    using System;
    using Windows.Devices.Input;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(TappedEventArgs)), Version(0x6020000), Guid(0xcfa126e4, 0x253a, 0x4c3c, 0x95, 0x3b, 0x39, 0x5c, 0x37, 0xae, 0xd3, 9)]
    internal interface ITappedEventArgs
    {
        Windows.Devices.Input.PointerDeviceType PointerDeviceType { get; }

        Point Position { get; }

        uint TapCount { get; }
    }
}

