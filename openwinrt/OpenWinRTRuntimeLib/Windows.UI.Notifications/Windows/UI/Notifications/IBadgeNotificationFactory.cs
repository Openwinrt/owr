namespace Windows.UI.Notifications
{
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xedf255ce, 0x618, 0x4d59, 0x94, 0x8a, 90, 0x61, 4, 12, 0x52, 0xf9), ExclusiveTo(typeof(BadgeNotification)), Version(0x6020000)]
    internal interface IBadgeNotificationFactory
    {
        BadgeNotification CreateBadgeNotification([In] XmlDocument content);
    }
}

