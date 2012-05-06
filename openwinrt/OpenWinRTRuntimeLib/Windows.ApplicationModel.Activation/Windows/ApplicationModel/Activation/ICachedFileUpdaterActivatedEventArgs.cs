namespace Windows.ApplicationModel.Activation
{
    using Windows.Foundation.Metadata;
    using Windows.Storage.Provider;

    [Guid(0xd06eb1c7, 0x3805, 0x4ecb, 0xb7, 0x57, 0x6c, 0xf1, 0x5e, 0x26, 0xfe, 0xf3), Version(0x6020000)]
    public interface ICachedFileUpdaterActivatedEventArgs : IActivatedEventArgs
    {
        Windows.Storage.Provider.CachedFileUpdaterUI CachedFileUpdaterUI { get; }
    }
}

