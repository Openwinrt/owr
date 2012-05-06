namespace Windows.Globalization
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Static(typeof(IApplicationPreferencesStatics), 0x6020000), Threading(ThreadingModel.Both), Version(0x6020000)]
    public static class ApplicationPreferences
    {
        public static string PreferredLanguage { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

