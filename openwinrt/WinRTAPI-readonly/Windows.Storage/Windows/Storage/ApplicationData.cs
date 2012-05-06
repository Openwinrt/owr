namespace Windows.Storage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Static(typeof(IApplicationDataStatics), 0x6020000), Threading(ThreadingModel.MTA)]
    public sealed class ApplicationData : IApplicationData
    {
        public event TypedEventHandler<ApplicationData, object> DataChanged;

        public event TypedEventHandler<ApplicationData, object> Windows.Storage.IApplicationData.DataChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("ClearAllAsync")]
        public IAsyncAction ClearAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("ClearAsync")]
        public IAsyncAction ClearAsync([In] ApplicationDataLocality locality);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction SetVersionAsync([In] uint desiredVersion, [In] ApplicationDataSetVersionHandler handler);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SignalDataChanged();

        public static ApplicationData Current { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StorageFolder LocalFolder { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ApplicationDataContainer LocalSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StorageFolder RoamingFolder { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ApplicationDataContainer RoamingSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ulong RoamingStorageQuota { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ulong RoamingStorageUsage { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StorageFolder TemporaryFolder { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Version { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StorageFolder Windows.Storage.IApplicationData.LocalFolder { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ApplicationDataContainer Windows.Storage.IApplicationData.LocalSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StorageFolder Windows.Storage.IApplicationData.RoamingFolder { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ApplicationDataContainer Windows.Storage.IApplicationData.RoamingSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ulong Windows.Storage.IApplicationData.RoamingStorageQuota { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ulong Windows.Storage.IApplicationData.RoamingStorageUsage { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StorageFolder Windows.Storage.IApplicationData.TemporaryFolder { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Storage.IApplicationData.Version { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

