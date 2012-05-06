namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0xef6a2e25, 0x3ff0, 0x4420, 0xa4, 0x11, 0x71, 130, 0xa4, 0xce, 0xcb, 0x15), ExclusiveTo(typeof(LineSegment)), Version(0x6020000)]
    internal interface ILineSegment
    {
        Windows.Foundation.Point Point { get; [param: In] set; }
    }
}

