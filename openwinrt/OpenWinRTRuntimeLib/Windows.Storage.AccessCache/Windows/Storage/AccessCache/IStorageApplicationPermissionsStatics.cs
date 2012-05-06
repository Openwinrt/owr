namespace Windows.Storage.AccessCache
{
    using Windows.Foundation.Metadata;

    [Guid(0x4391dfaa, 0xd033, 0x48f9, 0x80, 0x60, 0x3e, 200, 0x47, 210, 0xe3, 0xf1), ExclusiveTo(typeof(StorageApplicationPermissions)), Version(0x6020000)]
    internal interface IStorageApplicationPermissionsStatics
    {
        StorageItemAccessList FutureAccessList { get; }

        StorageItemMostRecentlyUsedList MostRecentlyUsedList { get; }
    }
}

