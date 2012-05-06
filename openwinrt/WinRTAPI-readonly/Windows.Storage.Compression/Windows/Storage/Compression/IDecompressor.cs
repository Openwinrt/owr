namespace Windows.Storage.Compression
{
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [ExclusiveTo(typeof(Decompressor)), Version(0x6020000), Guid(0xb883fe46, 0xd68a, 0x4c8b, 0xad, 160, 0x4e, 0xe8, 0x13, 0xfc, 0x52, 0x83)]
    internal interface IDecompressor : IInputStream, IClosable
    {
        IInputStream DetachStream();
    }
}

