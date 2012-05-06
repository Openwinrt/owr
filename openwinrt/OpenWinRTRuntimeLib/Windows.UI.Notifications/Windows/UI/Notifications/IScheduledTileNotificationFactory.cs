namespace Windows.UI.Notifications
{
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ScheduledTileNotification)), Windows.Foundation.Metadata.Guid(0x3383138a, 0x98c0, 0x4c3b, 0xbb, 0xd6, 0x4a, 0x63, 60, 0x7c, 0xfc, 0x29), Version(0x6020000)]
    internal interface IScheduledTileNotificationFactory
    {
        ScheduledTileNotification CreateScheduledTileNotification([In] XmlDocument content, [In] DateTime deliveryTime);
    }
}

