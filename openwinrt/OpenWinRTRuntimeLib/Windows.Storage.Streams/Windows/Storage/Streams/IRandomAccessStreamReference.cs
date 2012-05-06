namespace Windows.Storage.Streams
{
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x33ee3134, 0x1dd6, 0x4e3a, 0x80, 0x67, 0xd1, 0xc1, 0x62, 0xe8, 100, 0x2b)]
    public interface IRandomAccessStreamReference
    {
        IAsyncOperation<IRandomAccessStreamWithContentType> OpenReadAsync();
    }
}

