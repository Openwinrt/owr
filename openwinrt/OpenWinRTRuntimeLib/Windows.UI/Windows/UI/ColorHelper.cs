namespace Windows.UI
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Static(typeof(IColorHelperStatics), 0x6020000)]
    public sealed class ColorHelper : IColorHelper
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static Color FromArgb([In] byte a, [In] byte r, [In] byte g, [In] byte b);
    }
}

