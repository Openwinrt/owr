namespace Windows.Storage.Provider
{
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(FileUpdateRequestedEventArgs)), Version(0x6020000), Guid(0x7b0a9342, 0x3905, 0x438d, 170, 0xef, 120, 0xae, 0x26, 0x5f, 0x8d, 210)]
    internal interface IFileUpdateRequestedEventArgs
    {
        FileUpdateRequest Request { get; }
    }
}

