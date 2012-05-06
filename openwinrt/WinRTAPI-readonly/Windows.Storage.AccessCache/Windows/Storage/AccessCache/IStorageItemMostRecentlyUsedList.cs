namespace Windows.Storage.AccessCache
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x16239d5, 0x510d, 0x411e, 140, 0xf1, 0xc3, 0xd1, 0xef, 250, 0x4c, 0x33), Version(0x6020000), ExclusiveTo(typeof(StorageItemMostRecentlyUsedList))]
    internal interface IStorageItemMostRecentlyUsedList : IStorageItemAccessList
    {
        event TypedEventHandler<StorageItemMostRecentlyUsedList, ItemRemovedEventArgs> ItemRemoved;
    }
}

