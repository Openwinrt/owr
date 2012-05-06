namespace Windows.UI.StartScreen
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(SecondaryTile)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x57f52ca0, 0x51bc, 0x4abf, 0x8e, 0xbf, 0x62, 0x7a, 3, 0x98, 0xb0, 90)]
    internal interface ISecondaryTileFactory
    {
        SecondaryTile CreateTile([In] string tileId, [In] string shortName, [In] string displayName, [In] string arguments, [In] TileOptions tileOptions, [In] Uri logoReference);
        SecondaryTile CreateWideTile([In] string tileId, [In] string shortName, [In] string displayName, [In] string arguments, [In] TileOptions tileOptions, [In] Uri logoReference, [In] Uri wideLogoReference);
        SecondaryTile CreateWithId([In] string tileId);
    }
}

