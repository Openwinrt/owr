namespace Windows.UI.Notifications
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.MTA), Version(0x6020000), Activatable(typeof(ITileNotificationFactory), 0x6020000)]
    public sealed class TileNotification : ITileNotification
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public TileNotification([In] XmlDocument content);

        public XmlDocument Content { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<Windows.Foundation.DateTime> ExpirationTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Tag { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public XmlDocument Windows.UI.Notifications.ITileNotification.Content { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<Windows.Foundation.DateTime> Windows.UI.Notifications.ITileNotification.ExpirationTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Notifications.ITileNotification.Tag { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

