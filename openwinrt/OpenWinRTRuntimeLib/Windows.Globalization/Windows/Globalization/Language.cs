namespace Windows.Globalization
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Activatable(typeof(ILanguageFactory), 0x6020000), Threading(ThreadingModel.Both), DualApiPartition(version=0x6020000), Activatable(0x6020000), Static(typeof(ILanguageStatics), 0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class Language : ILanguage
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Language();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Language([In] string languageTag);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool IsWellFormed([In] string languageTag);

        public static string CurrentInputMethodLanguageTag { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string DisplayName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string LanguageTag { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string NativeName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Script { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Globalization.ILanguage.DisplayName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Globalization.ILanguage.LanguageTag { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Globalization.ILanguage.NativeName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Globalization.ILanguage.Script { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

