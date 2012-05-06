namespace Windows.ApplicationModel.Activation
{
    using Windows.Foundation.Metadata;
    using Windows.Storage.Pickers.Provider;

    [Version(0x6020000), Guid(0x81c19cf1, 0x74e6, 0x4387, 130, 0xeb, 0xbb, 0x8f, 0xd6, 0x4b, 0x43, 70)]
    public interface IFileSavePickerActivatedEventArgs : IActivatedEventArgs
    {
        Windows.Storage.Pickers.Provider.FileSavePickerUI FileSavePickerUI { get; }
    }
}

