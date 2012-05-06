namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), Static(typeof(ISizeHelperStatics), 0x6020000)]
    public sealed class SizeHelper : ISizeHelper
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool Equals([In] Size target, [In] Size value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static Size FromDimensions([In] float width, [In] float height);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetIsEmpty([In] Size target);

        public static Size Empty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

