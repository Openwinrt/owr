namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x36805271, 0x38c4, 0x4bcf, 150, 0xcd, 2, 0x8a, 0x6d, 0x38, 0xaf, 0x25), WebHostHidden, ExclusiveTo(typeof(PolyBezierSegment)), Version(0x6020000)]
    internal interface IPolyBezierSegment
    {
        PointCollection Points { get; [param: In] set; }
    }
}

