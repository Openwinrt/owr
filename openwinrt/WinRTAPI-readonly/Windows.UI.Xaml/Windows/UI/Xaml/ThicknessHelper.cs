namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Static(typeof(IThicknessHelperStatics), 0x6020000), Version(0x6020000)]
    public sealed class ThicknessHelper : IThicknessHelper
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static Thickness FromLengths([In] double left, [In] double top, [In] double right, [In] double bottom);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static Thickness FromUniformLength([In] double uniformLength);
    }
}

