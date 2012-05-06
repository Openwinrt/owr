namespace Windows.ApplicationModel.Background
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Static(typeof(IBackgroundExecutionManagerStatics), 0x6020000)]
    public static class BackgroundExecutionManager
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetAccessStatus")]
        public static BackgroundAccessStatus GetAccessStatus();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetAccessStatusForApplication")]
        public static BackgroundAccessStatus GetAccessStatus([In] string applicationId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RemoveAccess")]
        public static void RemoveAccess();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RemoveAccessForApplication")]
        public static void RemoveAccess([In] string applicationId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RequestAccessAsync")]
        public static IAsyncOperation<BackgroundAccessStatus> RequestAccessAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RequestAccessForApplicationAsync")]
        public static IAsyncOperation<BackgroundAccessStatus> RequestAccessAsync([In] string applicationId);
    }
}

