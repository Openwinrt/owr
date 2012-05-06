namespace Windows.UI.Notifications
{
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xc6abdd6e, 0x4928, 0x46c8, 0xbd, 0xbf, 0x81, 160, 0x47, 0xde, 160, 0xd4), ExclusiveTo(typeof(TileNotification)), Version(0x6020000)]
    internal interface ITileNotificationFactory
    {
        TileNotification CreateTileNotification([In] XmlDocument content);
    }
}

