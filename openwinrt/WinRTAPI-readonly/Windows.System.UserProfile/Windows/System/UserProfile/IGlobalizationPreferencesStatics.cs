namespace Windows.System.UserProfile
{
    using System;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Globalization;

    [Guid(0x1bf4326, 0xed37, 0x4e96, 0xb0, 0xe9, 0xc1, 0x34, 13, 30, 0xa1, 0x58), ExclusiveTo(typeof(GlobalizationPreferences)), Version(0x6020000)]
    internal interface IGlobalizationPreferencesStatics
    {
        IVectorView<string> Calendars { get; }

        IVectorView<string> Clocks { get; }

        IVectorView<string> Currencies { get; }

        string HomeGeographicRegion { get; }

        IVectorView<string> Languages { get; }

        Windows.Globalization.DayOfWeek WeekStartsOn { get; }
    }
}

