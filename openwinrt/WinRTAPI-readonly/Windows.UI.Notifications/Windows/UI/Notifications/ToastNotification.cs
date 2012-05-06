namespace Windows.UI.Notifications
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Activatable(typeof(IToastNotificationFactory), 0x6020000), Threading(ThreadingModel.MTA), Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class ToastNotification : IToastNotification
    {
        public event TypedEventHandler<ToastNotification, object> Activated;

        public event TypedEventHandler<ToastNotification, ToastDismissedEventArgs> Dismissed;

        public event TypedEventHandler<ToastNotification, ToastFailedEventArgs> Failed;

        public event TypedEventHandler<ToastNotification, object> Windows.UI.Notifications.IToastNotification.Activated;

        public event TypedEventHandler<ToastNotification, ToastDismissedEventArgs> Windows.UI.Notifications.IToastNotification.Dismissed;

        public event TypedEventHandler<ToastNotification, ToastFailedEventArgs> Windows.UI.Notifications.IToastNotification.Failed;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ToastNotification([In] XmlDocument content);

        public XmlDocument Content { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<Windows.Foundation.DateTime> ExpirationTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public XmlDocument Windows.UI.Notifications.IToastNotification.Content { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<Windows.Foundation.DateTime> Windows.UI.Notifications.IToastNotification.ExpirationTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

