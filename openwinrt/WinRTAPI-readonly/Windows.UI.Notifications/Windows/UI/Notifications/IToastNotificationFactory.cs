namespace Windows.UI.Notifications
{
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x4124b20, 0x82c6, 0x4229, 0xb1, 9, 0xfd, 0x9e, 0xd4, 0x66, 0x2b, 0x53), ExclusiveTo(typeof(ToastNotification)), Version(0x6020000)]
    internal interface IToastNotificationFactory
    {
        ToastNotification CreateToastNotification([In] XmlDocument content);
    }
}

