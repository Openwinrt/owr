namespace Windows.Networking.PushNotifications
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class RawNotification : IRawNotification
    {
        public string Content { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.PushNotifications.IRawNotification.Content { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

