namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(RectHelper)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x5ee163e4, 0xc17e, 0x494f, 0xb5, 0x80, 0x2f, 5, 0x74, 0xfc, 0x3a, 0x15), WebHostHidden]
    internal interface IRectHelperStatics
    {
        bool Contains([In] Rect target, [In] Point point);
        bool Equals([In] Rect target, [In] Rect value);
        Rect FromCoordinatesAndDimensions([In] float x, [In] float y, [In] float width, [In] float height);
        Rect FromLocationAndSize([In] Point location, [In] Size size);
        Rect FromPoints([In] Point point1, [In] Point point2);
        float GetBottom([In] Rect target);
        bool GetIsEmpty([In] Rect target);
        float GetLeft([In] Rect target);
        float GetRight([In] Rect target);
        float GetTop([In] Rect target);
        Rect Intersect([In] Rect target, [In] Rect rect);
        [Overload("UnionWithPoint"), DefaultOverload]
        Rect Union([In] Rect target, [In] Point point);
        [Overload("UnionWithRect")]
        Rect Union([In] Rect target, [In] Rect rect);

        Rect Empty { get; }
    }
}

