namespace Windows.Networking.PushNotifications
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Notifications;

    [Version(0x6020000), ExclusiveTo(typeof(PushNotificationReceivedEventArgs)), Windows.Foundation.Metadata.Guid(0xd1065e0c, 0x36cd, 0x484c, 0xb9, 0x35, 10, 0x99, 0xb7, 0x53, 0xcf, 0)]
    internal interface IPushNotificationReceivedEventArgs
    {
        Windows.UI.Notifications.BadgeNotification BadgeNotification { get; }

        bool Cancel { get; [param: In] set; }

        PushNotificationType NotificationType { get; }

        Windows.UI.Notifications.TileNotification TileNotification { get; }

        Windows.UI.Notifications.ToastNotification ToastNotification { get; }
    }
}

