namespace Windows.ApplicationModel.Activation
{
    using Windows.Foundation.Metadata;
    using Windows.Storage.Pickers.Provider;

    [Guid(0x72827082, 0x5525, 0x4bf2, 0xbc, 9, 0x1f, 80, 0x95, 0xd4, 150, 0x4d), Version(0x6020000)]
    public interface IFileOpenPickerActivatedEventArgs : IActivatedEventArgs
    {
        Windows.Storage.Pickers.Provider.FileOpenPickerUI FileOpenPickerUI { get; }
    }
}

