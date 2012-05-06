namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0xf57ae6ca, 0xd1a6, 0x4b90, 0xa4, 0xe9, 0x54, 0xdf, 0x1b, 0xa8, 210, 0xec), ExclusiveTo(typeof(ScrollBar))]
    internal interface IScrollBar
    {
        event ScrollEventHandler Scroll;

        ScrollingIndicatorMode IndicatorMode { get; [param: In] set; }

        Windows.UI.Xaml.Controls.Orientation Orientation { get; [param: In] set; }

        double ViewportSize { get; [param: In] set; }
    }
}

