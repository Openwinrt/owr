namespace Windows.UI.Notifications
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x75927b93, 0x3f3, 0x41ec, 0x91, 0xd3, 110, 0x5b, 0xac, 0x1b, 0x38, 0xe7), Version(0x6020000), ExclusiveTo(typeof(ToastNotifier))]
    internal interface IToastNotifier
    {
        void AddToSchedule([In] ScheduledToastNotification scheduledToast);
        IVectorView<ScheduledToastNotification> GetScheduledToastNotifications();
        void Hide([In] ToastNotification notification);
        void RemoveFromSchedule([In] ScheduledToastNotification scheduledToast);
        void Show([In] ToastNotification notification);

        NotificationSetting Setting { get; }
    }
}

