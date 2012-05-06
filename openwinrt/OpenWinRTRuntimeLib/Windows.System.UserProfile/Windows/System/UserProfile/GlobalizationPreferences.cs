namespace Windows.System.UserProfile
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Globalization;

    [Static(typeof(IGlobalizationPreferencesStatics), 0x6020000), DualApiPartition(version=0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public static class GlobalizationPreferences
    {
        public static IVectorView<string> Calendars { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static IVectorView<string> Clocks { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static IVectorView<string> Currencies { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string HomeGeographicRegion { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static IVectorView<string> Languages { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static Windows.Globalization.DayOfWeek WeekStartsOn { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

