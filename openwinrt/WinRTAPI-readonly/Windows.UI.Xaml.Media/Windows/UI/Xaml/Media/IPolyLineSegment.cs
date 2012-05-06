namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x4b397f87, 0xa2e6, 0x479d, 0xbd, 200, 0x6f, 0x44, 100, 100, 0x68, 0x87), ExclusiveTo(typeof(PolyLineSegment))]
    internal interface IPolyLineSegment
    {
        PointCollection Points { get; [param: In] set; }
    }
}

