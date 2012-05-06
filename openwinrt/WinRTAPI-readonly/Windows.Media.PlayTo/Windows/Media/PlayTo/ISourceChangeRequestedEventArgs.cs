namespace Windows.Media.PlayTo
{
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Guid(0xfb3f3a96, 0x7aa6, 0x4a8b, 0x86, 0xe7, 0x54, 0xf6, 0xc6, 0xd3, 0x4f, 100), ExclusiveTo(typeof(SourceChangeRequestedEventArgs)), Version(0x6020000)]
    internal interface ISourceChangeRequestedEventArgs
    {
        IRandomAccessStreamWithContentType Stream { get; }
    }
}

