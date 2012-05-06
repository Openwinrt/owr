namespace Windows.UI.Notifications
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(TileUpdateManager)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xda159e5d, 0x3ea9, 0x4986, 0x8d, 0x84, 0xb0, 0x9d, 0x5e, 0x12, 0x27, 0x6d)]
    internal interface ITileUpdateManagerStatics
    {
        [Overload("CreateTileUpdaterForApplication")]
        TileUpdater CreateTileUpdaterForApplication();
        [Overload("CreateTileUpdaterForApplicationWithId")]
        TileUpdater CreateTileUpdaterForApplication([In] string applicationId);
        TileUpdater CreateTileUpdaterForSecondaryTile([In] string tileId);
        XmlDocument GetTemplateContent([In] TileTemplateType type);
    }
}

