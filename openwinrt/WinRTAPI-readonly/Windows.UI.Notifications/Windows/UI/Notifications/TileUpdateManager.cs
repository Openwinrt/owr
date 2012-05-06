namespace Windows.UI.Notifications
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation.Metadata;

    [Static(typeof(ITileUpdateManagerStatics), 0x6020000), Version(0x6020000), Threading(ThreadingModel.MTA)]
    public static class TileUpdateManager
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateTileUpdaterForApplication")]
        public static TileUpdater CreateTileUpdaterForApplication();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateTileUpdaterForApplicationWithId")]
        public static TileUpdater CreateTileUpdaterForApplication([In] string applicationId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static TileUpdater CreateTileUpdaterForSecondaryTile([In] string tileId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static XmlDocument GetTemplateContent([In] TileTemplateType type);
    }
}

