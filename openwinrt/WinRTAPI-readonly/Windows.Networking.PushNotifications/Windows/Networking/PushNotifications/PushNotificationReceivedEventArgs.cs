namespace Windows.Networking.PushNotifications
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Notifications;

    [Version(0x6020000)]
    public sealed class PushNotificationReceivedEventArgs : IPushNotificationReceivedEventArgs
    {
        public Windows.UI.Notifications.BadgeNotification BadgeNotification { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Cancel { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PushNotificationType NotificationType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Notifications.TileNotification TileNotification { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Notifications.ToastNotification ToastNotification { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Notifications.BadgeNotification Windows.Networking.PushNotifications.IPushNotificationReceivedEventArgs.BadgeNotification { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Networking.PushNotifications.IPushNotificationReceivedEventArgs.Cancel { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PushNotificationType Windows.Networking.PushNotifications.IPushNotificationReceivedEventArgs.NotificationType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Notifications.TileNotification Windows.Networking.PushNotifications.IPushNotificationReceivedEventArgs.TileNotification { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Notifications.ToastNotification Windows.Networking.PushNotifications.IPushNotificationReceivedEventArgs.ToastNotification { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

