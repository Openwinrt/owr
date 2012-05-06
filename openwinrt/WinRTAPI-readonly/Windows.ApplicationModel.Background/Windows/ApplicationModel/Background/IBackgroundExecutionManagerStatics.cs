namespace Windows.ApplicationModel.Background
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xe826ea58, 0x66a9, 0x4d41, 0x83, 0xd4, 180, 0xc1, 140, 0x87, 0xb8, 70), Version(0x6020000), ExclusiveTo(typeof(BackgroundExecutionManager))]
    internal interface IBackgroundExecutionManagerStatics
    {
        [Overload("GetAccessStatus")]
        BackgroundAccessStatus GetAccessStatus();
        [Overload("GetAccessStatusForApplication")]
        BackgroundAccessStatus GetAccessStatus([In] string applicationId);
        [Overload("RemoveAccess")]
        void RemoveAccess();
        [Overload("RemoveAccessForApplication")]
        void RemoveAccess([In] string applicationId);
        [Overload("RequestAccessAsync")]
        IAsyncOperation<BackgroundAccessStatus> RequestAccessAsync();
        [Overload("RequestAccessForApplicationAsync")]
        IAsyncOperation<BackgroundAccessStatus> RequestAccessAsync([In] string applicationId);
    }
}

