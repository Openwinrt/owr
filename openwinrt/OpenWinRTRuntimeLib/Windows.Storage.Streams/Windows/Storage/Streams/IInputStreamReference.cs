namespace Windows.Storage.Streams
{
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x43929d18, 0x5ec9, 0x4b5a, 0x91, 0x9c, 0x42, 5, 0xb0, 200, 4, 0xb6)]
    public interface IInputStreamReference
    {
        IAsyncOperation<IInputStream> OpenSequentialReadAsync();
    }
}

