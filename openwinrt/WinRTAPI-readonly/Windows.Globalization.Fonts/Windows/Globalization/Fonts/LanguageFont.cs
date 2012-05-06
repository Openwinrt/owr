namespace Windows.Globalization.Fonts
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Text;

    [DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class LanguageFont : ILanguageFont
    {
        public string FontFamily { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Text.FontStretch FontStretch { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Text.FontStyle FontStyle { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Text.FontWeight FontWeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double ScaleFactor { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Globalization.Fonts.ILanguageFont.FontFamily { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Text.FontStretch Windows.Globalization.Fonts.ILanguageFont.FontStretch { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Text.FontStyle Windows.Globalization.Fonts.ILanguageFont.FontStyle { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Text.FontWeight Windows.Globalization.Fonts.ILanguageFont.FontWeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.Globalization.Fonts.ILanguageFont.ScaleFactor { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

