namespace Windows.Media.PlayTo
{
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(PlayToConnectionStateChangedEventArgs)), Version(0x6020000), Guid(0x68c4b50f, 0xc20, 0x4980, 0x86, 2, 0x58, 0xc6, 0x22, 0x38, 0xd4, 0x23)]
    internal interface IPlayToConnectionStateChangedEventArgs
    {
        PlayToConnectionState CurrentState { get; }

        PlayToConnectionState PreviousState { get; }
    }
}

