namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Static(typeof(IDataTransferManagerStatics), 0x6020000)]
    public sealed class DataTransferManager : IDataTransferManager
    {
        public event TypedEventHandler<DataTransferManager, DataRequestedEventArgs> DataRequested;

        public event TypedEventHandler<DataTransferManager, TargetApplicationChosenEventArgs> TargetApplicationChosen;

        public event TypedEventHandler<DataTransferManager, DataRequestedEventArgs> Windows.ApplicationModel.DataTransfer.IDataTransferManager.DataRequested;

        public event TypedEventHandler<DataTransferManager, TargetApplicationChosenEventArgs> Windows.ApplicationModel.DataTransfer.IDataTransferManager.TargetApplicationChosen;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static DataTransferManager GetForCurrentView();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void ShowShareUI();
    }
}

