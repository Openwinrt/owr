namespace Windows.Networking.PushNotifications
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(PushNotificationChannelManager)), Windows.Foundation.Metadata.Guid(0x8baf9b65, 0x77a1, 0x4588, 0xbd, 0x19, 0x86, 0x15, 0x29, 0xa9, 220, 240)]
    internal interface IPushNotificationChannelManagerStatics
    {
        [Overload("CreatePushNotificationChannelForApplicationAsync")]
        IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync();
        [Overload("CreatePushNotificationChannelForApplicationAsyncWithId")]
        IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync([In] string applicationId);
        IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForSecondaryTileAsync([In] string tileId);
    }
}

