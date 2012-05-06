namespace Windows.Storage.Compression
{
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Version(0x6020000), ExclusiveTo(typeof(Compressor)), Guid(0xac3645a, 0x57ac, 0x4ee1, 0xb7, 2, 0x84, 0xd3, 0x9d, 0x54, 0x24, 0xe0)]
    internal interface ICompressor : IOutputStream, IClosable
    {
        IOutputStream DetachStream();
        StreamFlushOperation FinishAsync();
    }
}

