namespace Windows.Globalization.DateTimeFormatting
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(DateTimeFormatter)), Windows.Foundation.Metadata.Guid(0xec8d8a53, 0x1a2e, 0x412d, 0x88, 0x15, 0x3b, 0x74, 0x5f, 0xb1, 0xa2, 160)]
    internal interface IDateTimeFormatterFactory
    {
        DateTimeFormatter CreateDateTimeFormatter([In] string formatTemplate);
        DateTimeFormatter CreateDateTimeFormatterContext([In] string formatTemplate, [In] IIterable<string> languages, [In] string geographicRegion, [In] string calendar, [In] string clock);
        DateTimeFormatter CreateDateTimeFormatterDate([In] YearFormat yearFormat, [In] MonthFormat monthFormat, [In] DayFormat dayFormat, [In] DayOfWeekFormat dayOfWeekFormat);
        DateTimeFormatter CreateDateTimeFormatterDateTimeContext([In] YearFormat yearFormat, [In] MonthFormat monthFormat, [In] DayFormat dayFormat, [In] DayOfWeekFormat dayOfWeekFormat, [In] HourFormat hourFormat, [In] MinuteFormat minuteFormat, [In] SecondFormat secondFormat, [In] IIterable<string> languages, [In] string geographicRegion, [In] string calendar, [In] string clock);
        DateTimeFormatter CreateDateTimeFormatterDateTimeLanguages([In] YearFormat yearFormat, [In] MonthFormat monthFormat, [In] DayFormat dayFormat, [In] DayOfWeekFormat dayOfWeekFormat, [In] HourFormat hourFormat, [In] MinuteFormat minuteFormat, [In] SecondFormat secondFormat, [In] IIterable<string> languages);
        DateTimeFormatter CreateDateTimeFormatterLanguages([In] string formatTemplate, [In] IIterable<string> languages);
        DateTimeFormatter CreateDateTimeFormatterTime([In] HourFormat hourFormat, [In] MinuteFormat minuteFormat, [In] SecondFormat secondFormat);
    }
}

