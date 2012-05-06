namespace Windows.UI.Notifications
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Activatable(typeof(IScheduledToastNotificationFactory), 0x6020000), Threading(ThreadingModel.MTA)]
    public sealed class ScheduledToastNotification : IScheduledToastNotification
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ScheduledToastNotification([In] XmlDocument content, [In] Windows.Foundation.DateTime deliveryTime);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ScheduledToastNotification([In] XmlDocument content, [In] Windows.Foundation.DateTime deliveryTime, [In] Windows.Foundation.TimeSpan snoozeInterval, [In] uint maximumSnoozeCount);

        public XmlDocument Content { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime DeliveryTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint MaximumSnoozeCount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<Windows.Foundation.TimeSpan> SnoozeInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public XmlDocument Windows.UI.Notifications.IScheduledToastNotification.Content { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.UI.Notifications.IScheduledToastNotification.DeliveryTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.UI.Notifications.IScheduledToastNotification.Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.UI.Notifications.IScheduledToastNotification.MaximumSnoozeCount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<Windows.Foundation.TimeSpan> Windows.UI.Notifications.IScheduledToastNotification.SnoozeInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

