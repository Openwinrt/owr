namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Static(typeof(IGridLengthHelperStatics), 0x6020000), Version(0x6020000), WebHostHidden]
    public sealed class GridLengthHelper : IGridLengthHelper
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool Equals([In] GridLength target, [In] GridLength value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static GridLength FromPixels([In] double pixels);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static GridLength FromValueAndType([In] double value, [In] GridUnitType type);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetIsAbsolute([In] GridLength target);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetIsAuto([In] GridLength target);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetIsStar([In] GridLength target);

        public static GridLength Auto { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

