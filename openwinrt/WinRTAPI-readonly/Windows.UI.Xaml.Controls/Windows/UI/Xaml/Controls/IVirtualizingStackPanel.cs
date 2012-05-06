namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(VirtualizingStackPanel)), Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x7567cd9a, 0xa3b4, 0x4dea, 0xbb, 0x11, 0x54, 0x9e, 0x2c, 0x2f, 0x91, 0x9d)]
    internal interface IVirtualizingStackPanel
    {
        event CleanUpVirtualizedItemEventHandler CleanUpVirtualizedItemEvent;

        bool AreScrollSnapPointsRegular { get; [param: In] set; }

        Windows.UI.Xaml.Controls.Orientation Orientation { get; [param: In] set; }
    }
}

