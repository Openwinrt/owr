namespace Windows.Security.ExchangeActiveSyncProvisioning
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(EasClientDeviceInformation)), Guid(0x54dfd981, 0x1968, 0x4ca3, 0xb9, 0x58, 0xe5, 0x95, 0xd1, 0x65, 5, 0xeb), Version(0x6020000)]
    internal interface IEasClientDeviceInformation
    {
        string FriendlyName { get; }

        Guid Id { get; }

        string OperatingSystem { get; }

        string SystemManufacturer { get; }

        string SystemProductName { get; }

        string SystemSku { get; }
    }
}

