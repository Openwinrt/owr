namespace Windows.ApplicationModel.DataTransfer.ShareTarget
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.ApplicationModel.DataTransfer;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ShareOperation)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x2246bab8, 0xd0f8, 0x41c1, 0xa8, 0x2a, 0x41, 0x37, 0xdb, 0x65, 4, 0xfb)]
    internal interface IShareOperation
    {
        void RemoveThisQuickLink();
        [Overload("ReportCompleted")]
        void ReportCompleted();
        [Overload("ReportCompletedWithQuickLink")]
        void ReportCompleted([In] QuickLink quicklink);
        void ReportDataRetrieved();
        void ReportError([In] string value);
        void ReportStarted();
        void ReportSubmittedBackgroundTask();

        DataPackageView Data { get; }

        string QuickLinkId { get; }
    }
}

