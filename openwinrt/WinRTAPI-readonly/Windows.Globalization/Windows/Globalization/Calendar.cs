namespace Windows.Globalization
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Static(typeof(ICalendarStatics), 0x6020000), Activatable(typeof(ICalendarFactory), 0x6020000), Activatable(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Threading(ThreadingModel.Both), DualApiPartition(version=0x6020000)]
    public sealed class Calendar : ICalendar
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Calendar();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Calendar([In] IIterable<string> languages);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Calendar([In] IIterable<string> languages, [In] string calendar, [In] string clock);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void AddDays([In] int days);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void AddEras([In] int eras);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void AddHours([In] int hours);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void AddMinutes([In] int minutes);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void AddMonths([In] int months);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void AddNanoseconds([In] int nanoseconds);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void AddSeconds([In] int seconds);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void AddWeeks([In] int weeks);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void AddYears([In] int years);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ChangeCalendarSystem([In] string value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ChangeClock([In] string value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Calendar Clone();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static int Compare([In] Calendar left, [In] Calendar right);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string DayAsPaddedString([In] int minDigits);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string DayAsString();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("DayOfWeekAsFullSoloString")]
        public string DayOfWeekAsSoloString();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("DayOfWeekAsSoloString")]
        public string DayOfWeekAsSoloString([In] int idealLength);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("DayOfWeekAsFullString")]
        public string DayOfWeekAsString();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("DayOfWeekAsString")]
        public string DayOfWeekAsString([In] int idealLength);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("EraAsFullString"), DefaultOverload]
        public string EraAsString();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("EraAsString")]
        public string EraAsString([In] int idealLength);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void FromDateTime([In] Windows.Foundation.DateTime value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string GetCalendarSystem();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string GetClock();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Windows.Foundation.DateTime GetDateTime();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string HourAsPaddedString([In] int minDigits);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string HourAsString();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string MinuteAsPaddedString([In] int minDigits);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string MinuteAsString();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string MonthAsNumericString();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string MonthAsPaddedNumericString([In] int minDigits);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("MonthAsFullSoloString")]
        public string MonthAsSoloString();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("MonthAsSoloString")]
        public string MonthAsSoloString([In] int idealLength);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("MonthAsFullString"), DefaultOverload]
        public string MonthAsString();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("MonthAsString")]
        public string MonthAsString([In] int idealLength);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string NanosecondAsPaddedString([In] int minDigits);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string NanosecondAsString();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Now();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("PeriodAsFullString")]
        public string PeriodAsString();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("PeriodAsString")]
        public string PeriodAsString([In] int idealLength);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string SecondAsPaddedString([In] int minDigits);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string SecondAsString();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetDateTime([In] Windows.Foundation.DateTime value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetToMax();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetToMin();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetToNow();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Windows.Foundation.DateTime ToDateTime();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string YearAsPaddedString([In] int minDigits);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string YearAsString();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string YearAsTruncatedString([In] int remainingDigits);

        public int Day { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Globalization.DayOfWeek DayOfWeek { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Era { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public int FirstDayInThisMonth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int FirstEra { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int FirstHourInThisPeriod { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int FirstMonthInThisYear { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int FirstPeriodInThisDay { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int FirstYearInThisEra { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Hour { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVectorView<string> Languages { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int LastDayInThisMonth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int LastEra { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int LastHourInThisPeriod { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int LastMonthInThisYear { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int LastPeriodInThisDay { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int LastYearInThisEra { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Calendar MaxSupported { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Calendar MinSupported { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Minute { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public int Month { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public int Nanosecond { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public int NumberOfDaysInThisMonth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int NumberOfEras { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int NumberOfHoursInThisPeriod { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int NumberOfMonthsInThisYear { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int NumberOfPeriodsInThisDay { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int NumberOfYearsInThisEra { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string NumeralSystem { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public int Period { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public int Second { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public int Windows.Globalization.ICalendar.Day { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Globalization.DayOfWeek Windows.Globalization.ICalendar.DayOfWeek { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Globalization.ICalendar.Era { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public int Windows.Globalization.ICalendar.FirstDayInThisMonth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Globalization.ICalendar.FirstEra { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Globalization.ICalendar.FirstHourInThisPeriod { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Globalization.ICalendar.FirstMonthInThisYear { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Globalization.ICalendar.FirstPeriodInThisDay { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Globalization.ICalendar.FirstYearInThisEra { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Globalization.ICalendar.Hour { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVectorView<string> Windows.Globalization.ICalendar.Languages { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Globalization.ICalendar.LastDayInThisMonth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Globalization.ICalendar.LastEra { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Globalization.ICalendar.LastHourInThisPeriod { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Globalization.ICalendar.LastMonthInThisYear { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Globalization.ICalendar.LastPeriodInThisDay { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Globalization.ICalendar.LastYearInThisEra { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Calendar Windows.Globalization.ICalendar.MaxSupported { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Calendar Windows.Globalization.ICalendar.MinSupported { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Globalization.ICalendar.Minute { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public int Windows.Globalization.ICalendar.Month { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public int Windows.Globalization.ICalendar.Nanosecond { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public int Windows.Globalization.ICalendar.NumberOfDaysInThisMonth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Globalization.ICalendar.NumberOfEras { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Globalization.ICalendar.NumberOfHoursInThisPeriod { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Globalization.ICalendar.NumberOfMonthsInThisYear { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Globalization.ICalendar.NumberOfPeriodsInThisDay { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Globalization.ICalendar.NumberOfYearsInThisEra { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Globalization.ICalendar.NumeralSystem { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public int Windows.Globalization.ICalendar.Period { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public int Windows.Globalization.ICalendar.Second { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public int Windows.Globalization.ICalendar.Year { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public int Year { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

