namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0xa9da01aa, 0xe00e, 0x4cfe, 170, 0x44, 0x2d, 0xd9, 50, 220, 0xa3, 0xd8), Version(0x6020000), ExclusiveTo(typeof(DataTransferManager))]
    internal interface IDataTransferManagerStatics
    {
        DataTransferManager GetForCurrentView();
        void ShowShareUI();
    }
}

