namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Static(typeof(ICornerRadiusHelperStatics), 0x6020000), Version(0x6020000), WebHostHidden]
    public sealed class CornerRadiusHelper : ICornerRadiusHelper
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static CornerRadius FromRadii([In] double topLeft, [In] double topRight, [In] double bottomRight, [In] double bottomLeft);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static CornerRadius FromUniformRadius([In] double uniformRadius);
    }
}

