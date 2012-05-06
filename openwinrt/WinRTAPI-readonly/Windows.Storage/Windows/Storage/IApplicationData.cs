namespace Windows.Storage
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x51c4d652, 0x6c0d, 0x4937, 160, 0x3b, 0x2d, 0x5f, 0xde, 0x3f, 0x2a, 0xf2), ExclusiveTo(typeof(ApplicationData))]
    internal interface IApplicationData
    {
        event TypedEventHandler<ApplicationData, object> DataChanged;

        [Overload("ClearAllAsync")]
        IAsyncAction ClearAsync();
        [Overload("ClearAsync")]
        IAsyncAction ClearAsync([In] ApplicationDataLocality locality);
        IAsyncAction SetVersionAsync([In] uint desiredVersion, [In] ApplicationDataSetVersionHandler handler);
        void SignalDataChanged();

        StorageFolder LocalFolder { get; }

        ApplicationDataContainer LocalSettings { get; }

        StorageFolder RoamingFolder { get; }

        ApplicationDataContainer RoamingSettings { get; }

        ulong RoamingStorageQuota { get; }

        ulong RoamingStorageUsage { get; }

        StorageFolder TemporaryFolder { get; }

        uint Version { get; }
    }
}

