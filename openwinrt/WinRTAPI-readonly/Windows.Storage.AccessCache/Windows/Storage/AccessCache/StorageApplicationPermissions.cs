namespace Windows.Storage.AccessCache
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Static(typeof(IStorageApplicationPermissionsStatics), 0x6020000), Version(0x6020000)]
    public static class StorageApplicationPermissions
    {
        public static StorageItemAccessList FutureAccessList { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static StorageItemMostRecentlyUsedList MostRecentlyUsedList { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

