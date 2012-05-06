namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), Static(typeof(IMatrixHelperStatics), 0x6020000)]
    public sealed class MatrixHelper : IMatrixHelper
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static Matrix FromElements([In] double m11, [In] double m12, [In] double m21, [In] double m22, [In] double offsetX, [In] double offsetY);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetIsIdentity([In] Matrix target);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static Point Transform([In] Matrix target, [In] Point point);

        public static Matrix Identity { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

