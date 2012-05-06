namespace Windows.Networking.NetworkOperators
{
    using System;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(MobileBroadbandDeviceInformation)), Version(0x6020000), Guid(0xe6d08168, 0xe381, 0x4c6e, 0x9b, 0xe8, 0xfe, 0x15, 0x69, 0x69, 0xa4, 70)]
    internal interface IMobileBroadbandDeviceInformation
    {
        Windows.Networking.NetworkOperators.CellularClass CellularClass { get; }

        MobileBroadbandRadioState CurrentRadioState { get; }

        string CustomDataClass { get; }

        Windows.Networking.NetworkOperators.DataClasses DataClasses { get; }

        string DeviceId { get; }

        MobileBroadbandDeviceType DeviceType { get; }

        string FirmwareInformation { get; }

        string Manufacturer { get; }

        string Model { get; }

        Windows.Networking.NetworkOperators.NetworkDeviceStatus NetworkDeviceStatus { get; }

        string SimIccId { get; }

        string SubscriberId { get; }

        IVectorView<string> TelephoneNumbers { get; }
    }
}

