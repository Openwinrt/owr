namespace Windows.Globalization.DateTimeFormatting
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(DateTimeFormatter)), Windows.Foundation.Metadata.Guid(0x95eeca10, 0x73e0, 0x4e4b, 0xa1, 0x83, 0x3d, 0x6a, 0xd0, 0xba, 0x35, 0xec), Version(0x6020000)]
    internal interface IDateTimeFormatter
    {
        string Format([In] Windows.Foundation.DateTime value);

        string Calendar { get; }

        string Clock { get; }

        string GeographicRegion { get; }

        DayFormat IncludeDay { get; }

        DayOfWeekFormat IncludeDayOfWeek { get; }

        HourFormat IncludeHour { get; }

        MinuteFormat IncludeMinute { get; }

        MonthFormat IncludeMonth { get; }

        SecondFormat IncludeSecond { get; }

        YearFormat IncludeYear { get; }

        IVectorView<string> Languages { get; }

        string NumeralSystem { get; [param: In] set; }

        IVectorView<string> Patterns { get; }

        string Template { get; }
    }
}

