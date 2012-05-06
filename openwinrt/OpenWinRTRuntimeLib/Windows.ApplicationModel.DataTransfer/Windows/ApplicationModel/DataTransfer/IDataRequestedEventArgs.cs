namespace Windows.ApplicationModel.DataTransfer
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0xcb8ba807, 0x6ac5, 0x43c9, 0x8a, 0xc5, 0x9b, 0xa2, 50, 0x16, 0x31, 130), ExclusiveTo(typeof(DataRequestedEventArgs))]
    internal interface IDataRequestedEventArgs
    {
        DataRequest Request { get; }
    }
}

