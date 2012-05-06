namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Static(typeof(IRectHelperStatics), 0x6020000), Version(0x6020000), WebHostHidden]
    public sealed class RectHelper : IRectHelper
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool Contains([In] Rect target, [In] Point point);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool Equals([In] Rect target, [In] Rect value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static Rect FromCoordinatesAndDimensions([In] float x, [In] float y, [In] float width, [In] float height);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static Rect FromLocationAndSize([In] Point location, [In] Size size);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static Rect FromPoints([In] Point point1, [In] Point point2);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static float GetBottom([In] Rect target);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetIsEmpty([In] Rect target);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static float GetLeft([In] Rect target);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static float GetRight([In] Rect target);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static float GetTop([In] Rect target);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static Rect Intersect([In] Rect target, [In] Rect rect);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("UnionWithPoint")]
        public static Rect Union([In] Rect target, [In] Point point);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("UnionWithRect")]
        public static Rect Union([In] Rect target, [In] Rect rect);

        public static Rect Empty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

