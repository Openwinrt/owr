namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0xdd5ced7d, 0xe6db, 0x4c96, 0xb6, 0xa1, 0x3f, 0xce, 150, 0xe9, 0x87, 0xa6), ExclusiveTo(typeof(PolyQuadraticBezierSegment))]
    internal interface IPolyQuadraticBezierSegment
    {
        PointCollection Points { get; [param: In] set; }
    }
}

