namespace Windows.Storage.Streams
{
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Guid(0xcc254827, 0x4b3d, 0x438f, 0x92, 50, 0x10, 0xc7, 0x6b, 0xc7, 0xe0, 0x38), Version(0x6020000)]
    public interface IRandomAccessStreamWithContentType : IRandomAccessStream, IClosable, IInputStream, IOutputStream, IContentTypeProvider
    {
    }
}

