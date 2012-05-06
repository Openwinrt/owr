namespace Windows.Media.PlayTo
{
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(PlayToSourceRequestedEventArgs)), Guid(0xc5cdc330, 0x29df, 0x4ec6, 0x9d, 0xa9, 0x9f, 0xbd, 0xfc, 0xfc, 0x1b, 0x3e), Version(0x6020000)]
    internal interface IPlayToSourceRequestedEventArgs
    {
        PlayToSourceRequest SourceRequest { get; }
    }
}

