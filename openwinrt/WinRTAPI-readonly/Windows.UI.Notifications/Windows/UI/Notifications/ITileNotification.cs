namespace Windows.UI.Notifications
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xebaec8fa, 0x50ec, 0x4c18, 180, 0xd0, 0x3a, 240, 0x2e, 0x55, 0x40, 0xab), Version(0x6020000), ExclusiveTo(typeof(TileNotification))]
    internal interface ITileNotification
    {
        XmlDocument Content { get; }

        IReference<Windows.Foundation.DateTime> ExpirationTime { get; [param: In] set; }

        string Tag { get; [param: In] set; }
    }
}

