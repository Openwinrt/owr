namespace Windows.Media.PlayTo
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(PlayToConnectionTransferredEventArgs)), Guid(0xfae3193a, 0x683, 0x47d9, 0x8d, 240, 0x18, 0xcb, 180, 0x89, 0x84, 0xd8)]
    internal interface IPlayToConnectionTransferredEventArgs
    {
        PlayToSource CurrentSource { get; }

        PlayToSource PreviousSource { get; }
    }
}

