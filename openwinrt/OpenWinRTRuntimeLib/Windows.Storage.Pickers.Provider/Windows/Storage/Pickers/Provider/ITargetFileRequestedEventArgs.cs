namespace Windows.Storage.Pickers.Provider
{
    using Windows.Foundation.Metadata;

    [Guid(0xb163dbc1, 0x1b51, 0x4c89, 0xa5, 0x91, 15, 0xd4, 11, 60, 0x57, 0xc9), ExclusiveTo(typeof(TargetFileRequestedEventArgs)), Version(0x6020000)]
    internal interface ITargetFileRequestedEventArgs
    {
        TargetFileRequest Request { get; }
    }
}

