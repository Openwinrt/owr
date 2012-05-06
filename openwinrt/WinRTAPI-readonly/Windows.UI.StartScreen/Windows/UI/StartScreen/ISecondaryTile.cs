namespace Windows.UI.StartScreen
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Popups;

    [ExclusiveTo(typeof(SecondaryTile)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xd8208249, 0x61b8, 0x4dc3, 0x93, 0xe2, 0xd8, 0xc4, 0x2e, 90, 190, 0xd0)]
    internal interface ISecondaryTile
    {
        [DefaultOverload, Overload("RequestCreateAsync")]
        IAsyncOperation<bool> RequestCreateAsync();
        [Overload("RequestCreateAsyncWithPoint"), DefaultOverload]
        IAsyncOperation<bool> RequestCreateAsync([In] Point invocationPoint);
        [Overload("RequestCreateAsyncWithRect"), DefaultOverload]
        IAsyncOperation<bool> RequestCreateForSelectionAsync([In] Rect selection);
        [DefaultOverload, Overload("RequestCreateAsyncWithRectAndPlacement")]
        IAsyncOperation<bool> RequestCreateForSelectionAsync([In] Rect selection, [In] Placement preferredPlacement);
        [Overload("RequestDeleteAsync"), DefaultOverload]
        IAsyncOperation<bool> RequestDeleteAsync();
        [Overload("RequestDeleteAsyncWithPoint"), DefaultOverload]
        IAsyncOperation<bool> RequestDeleteAsync([In] Point invocationPoint);
        [DefaultOverload, Overload("RequestDeleteAsyncWithRect")]
        IAsyncOperation<bool> RequestDeleteForSelectionAsync([In] Rect selection);
        [Overload("RequestDeleteAsyncWithRectAndPlacement"), DefaultOverload]
        IAsyncOperation<bool> RequestDeleteForSelectionAsync([In] Rect selection, [In] Placement preferredPlacement);
        IAsyncOperation<bool> UpdateAsync();

        string Arguments { get; [param: In] set; }

        string BackgroundColor { get; [param: In] set; }

        string DisplayName { get; [param: In] set; }

        Windows.UI.StartScreen.ForegroundText ForegroundText { get; [param: In] set; }

        Uri Logo { get; [param: In] set; }

        string ShortName { get; [param: In] set; }

        Uri SmallLogo { get; [param: In] set; }

        string TileId { get; [param: In] set; }

        Windows.UI.StartScreen.TileOptions TileOptions { get; [param: In] set; }

        Uri WideLogo { get; [param: In] set; }
    }
}

