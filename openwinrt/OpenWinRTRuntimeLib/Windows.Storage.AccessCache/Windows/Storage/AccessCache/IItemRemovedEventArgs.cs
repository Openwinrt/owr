namespace Windows.Storage.AccessCache
{
    using Windows.Foundation.Metadata;

    [Guid(0x59677e5c, 0x55be, 0x4c66, 0xba, 0x66, 0x5e, 0xae, 0xa7, 0x9d, 0x26, 0x31), Version(0x6020000), ExclusiveTo(typeof(ItemRemovedEventArgs))]
    internal interface IItemRemovedEventArgs
    {
        AccessListEntry RemovedEntry { get; }
    }
}

