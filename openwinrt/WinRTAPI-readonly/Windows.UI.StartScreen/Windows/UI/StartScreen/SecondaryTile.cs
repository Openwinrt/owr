namespace Windows.UI.StartScreen
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Popups;

    [Activatable(0x6020000), Activatable(typeof(ISecondaryTileFactory), 0x6020000), Version(0x6020000), Static(typeof(ISecondaryTileStatics), 0x6020000)]
    public sealed class SecondaryTile : ISecondaryTile
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SecondaryTile();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SecondaryTile([In] string tileId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SecondaryTile([In] string tileId, [In] string shortName, [In] string displayName, [In] string arguments, [In] Windows.UI.StartScreen.TileOptions tileOptions, [In] Uri logoReference);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SecondaryTile([In] string tileId, [In] string shortName, [In] string displayName, [In] string arguments, [In] Windows.UI.StartScreen.TileOptions tileOptions, [In] Uri logoReference, [In] Uri wideLogoReference);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool Exists([In] string tileId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("FindAllAsync"), DefaultOverload]
        public static IAsyncOperation<IVectorView<SecondaryTile>> FindAllAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("FindAllForApplicationAsync")]
        public static IAsyncOperation<IVectorView<SecondaryTile>> FindAllAsync([In] string applicationId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<IVectorView<SecondaryTile>> FindAllForPackageAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RequestCreateAsync"), DefaultOverload]
        public IAsyncOperation<bool> RequestCreateAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("RequestCreateAsyncWithPoint")]
        public IAsyncOperation<bool> RequestCreateAsync([In] Point invocationPoint);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RequestCreateAsyncWithRect"), DefaultOverload]
        public IAsyncOperation<bool> RequestCreateForSelectionAsync([In] Rect selection);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("RequestCreateAsyncWithRectAndPlacement")]
        public IAsyncOperation<bool> RequestCreateForSelectionAsync([In] Rect selection, [In] Placement preferredPlacement);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RequestDeleteAsync"), DefaultOverload]
        public IAsyncOperation<bool> RequestDeleteAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("RequestDeleteAsyncWithPoint")]
        public IAsyncOperation<bool> RequestDeleteAsync([In] Point invocationPoint);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RequestDeleteAsyncWithRect"), DefaultOverload]
        public IAsyncOperation<bool> RequestDeleteForSelectionAsync([In] Rect selection);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RequestDeleteAsyncWithRectAndPlacement"), DefaultOverload]
        public IAsyncOperation<bool> RequestDeleteForSelectionAsync([In] Rect selection, [In] Placement preferredPlacement);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<bool> UpdateAsync();

        public string Arguments { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string BackgroundColor { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string DisplayName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.StartScreen.ForegroundText ForegroundText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Uri Logo { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string ShortName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Uri SmallLogo { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string TileId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.StartScreen.TileOptions TileOptions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Uri WideLogo { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.StartScreen.ISecondaryTile.Arguments { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.StartScreen.ISecondaryTile.BackgroundColor { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.StartScreen.ISecondaryTile.DisplayName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.StartScreen.ForegroundText Windows.UI.StartScreen.ISecondaryTile.ForegroundText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Uri Windows.UI.StartScreen.ISecondaryTile.Logo { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.StartScreen.ISecondaryTile.ShortName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Uri Windows.UI.StartScreen.ISecondaryTile.SmallLogo { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.StartScreen.ISecondaryTile.TileId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.StartScreen.TileOptions Windows.UI.StartScreen.ISecondaryTile.TileOptions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Uri Windows.UI.StartScreen.ISecondaryTile.WideLogo { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

