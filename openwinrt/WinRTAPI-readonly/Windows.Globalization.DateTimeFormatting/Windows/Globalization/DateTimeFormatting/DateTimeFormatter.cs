namespace Windows.Globalization.DateTimeFormatting
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000), Activatable(typeof(IDateTimeFormatterFactory), 0x6020000), Static(typeof(IDateTimeFormatterStatics), 0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class DateTimeFormatter : IDateTimeFormatter
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DateTimeFormatter([In] string formatTemplate);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DateTimeFormatter([In] string formatTemplate, [In] IIterable<string> languages);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DateTimeFormatter([In] HourFormat hourFormat, [In] MinuteFormat minuteFormat, [In] SecondFormat secondFormat);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DateTimeFormatter([In] YearFormat yearFormat, [In] MonthFormat monthFormat, [In] DayFormat dayFormat, [In] DayOfWeekFormat dayOfWeekFormat);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DateTimeFormatter([In] string formatTemplate, [In] IIterable<string> languages, [In] string geographicRegion, [In] string calendar, [In] string clock);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DateTimeFormatter([In] YearFormat yearFormat, [In] MonthFormat monthFormat, [In] DayFormat dayFormat, [In] DayOfWeekFormat dayOfWeekFormat, [In] HourFormat hourFormat, [In] MinuteFormat minuteFormat, [In] SecondFormat secondFormat, [In] IIterable<string> languages);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DateTimeFormatter([In] YearFormat yearFormat, [In] MonthFormat monthFormat, [In] DayFormat dayFormat, [In] DayOfWeekFormat dayOfWeekFormat, [In] HourFormat hourFormat, [In] MinuteFormat minuteFormat, [In] SecondFormat secondFormat, [In] IIterable<string> languages, [In] string geographicRegion, [In] string calendar, [In] string clock);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string Format([In] Windows.Foundation.DateTime value);

        public string Calendar { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Clock { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string GeographicRegion { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DayFormat IncludeDay { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DayOfWeekFormat IncludeDayOfWeek { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public HourFormat IncludeHour { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MinuteFormat IncludeMinute { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MonthFormat IncludeMonth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SecondFormat IncludeSecond { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public YearFormat IncludeYear { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<string> Languages { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DateTimeFormatter LongDate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DateTimeFormatter LongTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string NumeralSystem { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVectorView<string> Patterns { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DateTimeFormatter ShortDate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DateTimeFormatter ShortTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Template { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Globalization.DateTimeFormatting.IDateTimeFormatter.Calendar { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Globalization.DateTimeFormatting.IDateTimeFormatter.Clock { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Globalization.DateTimeFormatting.IDateTimeFormatter.GeographicRegion { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DayFormat Windows.Globalization.DateTimeFormatting.IDateTimeFormatter.IncludeDay { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DayOfWeekFormat Windows.Globalization.DateTimeFormatting.IDateTimeFormatter.IncludeDayOfWeek { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public HourFormat Windows.Globalization.DateTimeFormatting.IDateTimeFormatter.IncludeHour { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MinuteFormat Windows.Globalization.DateTimeFormatting.IDateTimeFormatter.IncludeMinute { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MonthFormat Windows.Globalization.DateTimeFormatting.IDateTimeFormatter.IncludeMonth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SecondFormat Windows.Globalization.DateTimeFormatting.IDateTimeFormatter.IncludeSecond { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public YearFormat Windows.Globalization.DateTimeFormatting.IDateTimeFormatter.IncludeYear { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<string> Windows.Globalization.DateTimeFormatting.IDateTimeFormatter.Languages { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Globalization.DateTimeFormatting.IDateTimeFormatter.NumeralSystem { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVectorView<string> Windows.Globalization.DateTimeFormatting.IDateTimeFormatter.Patterns { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Globalization.DateTimeFormatting.IDateTimeFormatter.Template { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

