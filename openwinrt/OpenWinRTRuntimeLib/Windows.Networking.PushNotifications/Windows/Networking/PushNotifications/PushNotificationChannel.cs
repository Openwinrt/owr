namespace Windows.Networking.PushNotifications
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class PushNotificationChannel : IPushNotificationChannel
    {
        public event TypedEventHandler<PushNotificationChannel, PushNotificationReceivedEventArgs> PushNotificationReceived;

        public event TypedEventHandler<PushNotificationChannel, PushNotificationReceivedEventArgs> Windows.Networking.PushNotifications.IPushNotificationChannel.PushNotificationReceived;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Close();

        public Windows.Foundation.DateTime ExpirationTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Uri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.Networking.PushNotifications.IPushNotificationChannel.ExpirationTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.PushNotifications.IPushNotificationChannel.Uri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

