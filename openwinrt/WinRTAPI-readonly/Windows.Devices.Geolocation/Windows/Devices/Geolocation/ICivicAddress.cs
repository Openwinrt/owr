namespace Windows.Devices.Geolocation
{
    using System;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(CivicAddress)), Version(0x6020000), Guid(0xa8567a1a, 0x64f4, 0x4d48, 0xbc, 0xea, 0xf6, 0xb0, 8, 0xec, 0xa3, 0x4c)]
    internal interface ICivicAddress
    {
        string City { get; }

        string Country { get; }

        string PostalCode { get; }

        string State { get; }

        Windows.Foundation.DateTime Timestamp { get; }
    }
}

