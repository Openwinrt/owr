namespace Windows.UI.Notifications
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation.Metadata;

    [Static(typeof(IToastNotificationManagerStatics), 0x6020000), DualApiPartition(version=0x6020000), Threading(ThreadingModel.MTA), Version(0x6020000)]
    public static class ToastNotificationManager
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateToastNotifier")]
        public static ToastNotifier CreateToastNotifier();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateToastNotifierWithId")]
        public static ToastNotifier CreateToastNotifier([In] string applicationId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static XmlDocument GetTemplateContent([In] ToastTemplateType type);
    }
}

