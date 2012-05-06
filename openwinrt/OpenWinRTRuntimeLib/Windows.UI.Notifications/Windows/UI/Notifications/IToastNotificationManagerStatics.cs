namespace Windows.UI.Notifications
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x50ac103f, 0xd235, 0x4598, 0xbb, 0xef, 0x98, 0xfe, 0x4d, 0x1a, 0x3a, 0xd4), ExclusiveTo(typeof(ToastNotificationManager))]
    internal interface IToastNotificationManagerStatics
    {
        [Overload("CreateToastNotifier")]
        ToastNotifier CreateToastNotifier();
        [Overload("CreateToastNotifierWithId")]
        ToastNotifier CreateToastNotifier([In] string applicationId);
        XmlDocument GetTemplateContent([In] ToastTemplateType type);
    }
}

