namespace Windows.Networking.PushNotifications
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(PushNotificationChannel)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x2b28102e, 0xef0b, 0x4f39, 0x9b, 0x8a, 0xa3, 0xc1, 0x94, 0xde, 0x70, 0x81)]
    internal interface IPushNotificationChannel
    {
        event TypedEventHandler<PushNotificationChannel, PushNotificationReceivedEventArgs> PushNotificationReceived;

        void Close();

        Windows.Foundation.DateTime ExpirationTime { get; }

        string Uri { get; }
    }
}

