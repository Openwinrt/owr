namespace Windows.ApplicationModel.DataTransfer
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0xe7af329d, 0x51d, 0x4fab, 0xb1, 0xa9, 0x47, 0xfd, 0x77, 0xf7, 10, 0x41), ExclusiveTo(typeof(OperationCompletedEventArgs))]
    internal interface IOperationCompletedEventArgs
    {
        DataPackageOperation Operation { get; }
    }
}

