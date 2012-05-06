namespace Windows.UI.Notifications
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(ToastNotification)), Windows.Foundation.Metadata.Guid(0x997e2675, 0x59e, 0x4e60, 0x8b, 6, 0x17, 0x60, 0x91, 0x7c, 0x8b, 0x80)]
    internal interface IToastNotification
    {
        event TypedEventHandler<ToastNotification, object> Activated;

        event TypedEventHandler<ToastNotification, ToastDismissedEventArgs> Dismissed;

        event TypedEventHandler<ToastNotification, ToastFailedEventArgs> Failed;

        XmlDocument Content { get; }

        IReference<Windows.Foundation.DateTime> ExpirationTime { get; [param: In] set; }
    }
}

