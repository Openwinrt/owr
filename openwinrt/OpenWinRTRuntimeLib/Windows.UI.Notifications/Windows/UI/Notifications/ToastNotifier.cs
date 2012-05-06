namespace Windows.UI.Notifications
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class ToastNotifier : IToastNotifier
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void AddToSchedule([In] ScheduledToastNotification scheduledToast);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVectorView<ScheduledToastNotification> GetScheduledToastNotifications();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Hide([In] ToastNotification notification);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RemoveFromSchedule([In] ScheduledToastNotification scheduledToast);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Show([In] ToastNotification notification);

        public NotificationSetting Setting { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public NotificationSetting Windows.UI.Notifications.IToastNotifier.Setting { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

