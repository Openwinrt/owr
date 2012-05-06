namespace Windows.UI.Notifications
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Activatable(typeof(IBadgeNotificationFactory), 0x6020000), Threading(ThreadingModel.MTA), Version(0x6020000)]
    public sealed class BadgeNotification : IBadgeNotification
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public BadgeNotification([In] XmlDocument content);

        public XmlDocument Content { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<Windows.Foundation.DateTime> ExpirationTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public XmlDocument Windows.UI.Notifications.IBadgeNotification.Content { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<Windows.Foundation.DateTime> Windows.UI.Notifications.IBadgeNotification.ExpirationTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

