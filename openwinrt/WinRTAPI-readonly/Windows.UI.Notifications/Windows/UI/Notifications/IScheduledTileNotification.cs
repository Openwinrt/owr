namespace Windows.UI.Notifications
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xabca6d5, 0x99dc, 0x4c78, 0xa1, 0x1c, 0xc9, 0xe7, 0xf8, 0x6d, 0x7e, 0xf7), ExclusiveTo(typeof(ScheduledTileNotification)), Version(0x6020000)]
    internal interface IScheduledTileNotification
    {
        XmlDocument Content { get; }

        Windows.Foundation.DateTime DeliveryTime { get; }

        IReference<Windows.Foundation.DateTime> ExpirationTime { get; [param: In] set; }

        string Id { get; [param: In] set; }

        string Tag { get; [param: In] set; }
    }
}

