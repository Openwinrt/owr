namespace Windows.Networking.PushNotifications
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.MTA), Version(0x6020000), Static(typeof(IPushNotificationChannelManagerStatics), 0x6020000)]
    public static class PushNotificationChannelManager
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreatePushNotificationChannelForApplicationAsync")]
        public static IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreatePushNotificationChannelForApplicationAsyncWithId")]
        public static IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync([In] string applicationId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForSecondaryTileAsync([In] string tileId);
    }
}

