namespace Windows.UI.Notifications
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(ScheduledToastNotification)), Windows.Foundation.Metadata.Guid(0x79f577f8, 0xde7, 0x48cd, 0x97, 0x40, 0x9b, 0x37, 4, 0x90, 200, 0x38)]
    internal interface IScheduledToastNotification
    {
        XmlDocument Content { get; }

        Windows.Foundation.DateTime DeliveryTime { get; }

        string Id { get; [param: In] set; }

        uint MaximumSnoozeCount { get; }

        IReference<Windows.Foundation.TimeSpan> SnoozeInterval { get; }
    }
}

