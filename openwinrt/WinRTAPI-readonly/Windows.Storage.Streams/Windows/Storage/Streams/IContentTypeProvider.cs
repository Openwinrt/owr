namespace Windows.Storage.Streams
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x97d098a5, 0x3b99, 0x4de9, 0x88, 0xa5, 0xe1, 0x1d, 0x2f, 80, 0xc7, 0x95)]
    public interface IContentTypeProvider
    {
        string ContentType { get; }
    }
}

