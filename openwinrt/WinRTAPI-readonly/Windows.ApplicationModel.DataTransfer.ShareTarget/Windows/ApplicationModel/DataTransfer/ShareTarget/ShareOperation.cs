namespace Windows.ApplicationModel.DataTransfer.ShareTarget
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.ApplicationModel.DataTransfer;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class ShareOperation : IShareOperation
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RemoveThisQuickLink();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("ReportCompleted")]
        public void ReportCompleted();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("ReportCompletedWithQuickLink")]
        public void ReportCompleted([In] QuickLink quicklink);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ReportDataRetrieved();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ReportError([In] string value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ReportStarted();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ReportSubmittedBackgroundTask();

        public DataPackageView Data { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string QuickLinkId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DataPackageView Windows.ApplicationModel.DataTransfer.ShareTarget.IShareOperation.Data { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.DataTransfer.ShareTarget.IShareOperation.QuickLinkId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

