namespace Windows.UI.Text
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI;

    [Version(0x6020000), Threading(ThreadingModel.Both), Static(typeof(ITextConstantsStatics), 0x6020000)]
    public static class TextConstants
    {
        public static Color AutoColor { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static int MaxUnitCount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static int MinUnitCount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static Color UndefinedColor { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static float UndefinedFloatValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static FontStretch UndefinedFontStretch { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static FontStyle UndefinedFontStyle { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static int UndefinedInt32Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

