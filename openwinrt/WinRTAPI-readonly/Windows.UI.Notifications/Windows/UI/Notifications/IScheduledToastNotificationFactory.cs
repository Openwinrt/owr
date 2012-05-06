namespace Windows.UI.Notifications
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(ScheduledToastNotification)), Windows.Foundation.Metadata.Guid(0xe7bed191, 0xbb9, 0x4189, 0x83, 0x94, 0x31, 0x76, 0x1b, 0x47, 0x6f, 0xd7)]
    internal interface IScheduledToastNotificationFactory
    {
        [Overload("CreateScheduledToastNotification")]
        ScheduledToastNotification CreateScheduledToastNotification([In] XmlDocument content, [In] Windows.Foundation.DateTime deliveryTime);
        [Overload("CreateScheduledToastNotificationRecurring")]
        ScheduledToastNotification CreateScheduledToastNotification([In] XmlDocument content, [In] Windows.Foundation.DateTime deliveryTime, [In] Windows.Foundation.TimeSpan snoozeInterval, [In] uint maximumSnoozeCount);
    }
}

