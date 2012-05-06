namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Composable(typeof(IFontFamilyFactory), CompositionType.Public, 0x6020000), WebHostHidden, Version(0x6020000), Threading(ThreadingModel.Both)]
    public class FontFamily : IFontFamily
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public FontFamily([In] string familyName);

        public string Source { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.UI.Xaml.Media.IFontFamily.Source { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

