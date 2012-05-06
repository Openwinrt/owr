namespace Windows.UI.Notifications
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Activatable(typeof(IScheduledTileNotificationFactory), 0x6020000), Threading(ThreadingModel.MTA)]
    public sealed class ScheduledTileNotification : IScheduledTileNotification
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ScheduledTileNotification([In] XmlDocument content, [In] Windows.Foundation.DateTime deliveryTime);

        public XmlDocument Content { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime DeliveryTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<Windows.Foundation.DateTime> ExpirationTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Tag { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public XmlDocument Windows.UI.Notifications.IScheduledTileNotification.Content { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.UI.Notifications.IScheduledTileNotification.DeliveryTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<Windows.Foundation.DateTime> Windows.UI.Notifications.IScheduledTileNotification.ExpirationTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Notifications.IScheduledTileNotification.Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Notifications.IScheduledTileNotification.Tag { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

