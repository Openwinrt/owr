namespace Windows.UI.Notifications
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(BadgeNotification)), Windows.Foundation.Metadata.Guid(0x75cb4ca, 0xd08a, 0x4e2f, 0x92, 0x33, 0x7e, 40, 0x9c, 0x1f, 0x77, 0x22), Version(0x6020000)]
    internal interface IBadgeNotification
    {
        XmlDocument Content { get; }

        IReference<Windows.Foundation.DateTime> ExpirationTime { get; [param: In] set; }
    }
}

