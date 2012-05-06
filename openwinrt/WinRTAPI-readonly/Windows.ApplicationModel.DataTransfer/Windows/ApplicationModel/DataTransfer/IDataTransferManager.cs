namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(DataTransferManager)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xa5caee9b, 0x8708, 0x49d1, 0x8d, 0x36, 0x67, 210, 90, 0x8d, 160, 12)]
    internal interface IDataTransferManager
    {
        event TypedEventHandler<DataTransferManager, DataRequestedEventArgs> DataRequested;

        event TypedEventHandler<DataTransferManager, TargetApplicationChosenEventArgs> TargetApplicationChosen;
    }
}

