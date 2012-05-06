namespace Windows.Globalization
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(Calendar)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xca30221d, 0x86d9, 0x40fb, 0xa2, 0x6b, 0xd4, 0x4e, 0xb7, 0xcf, 8, 0xea)]
    internal interface ICalendar
    {
        void AddDays([In] int days);
        void AddEras([In] int eras);
        void AddHours([In] int hours);
        void AddMinutes([In] int minutes);
        void AddMonths([In] int months);
        void AddNanoseconds([In] int nanoseconds);
        void AddSeconds([In] int seconds);
        void AddWeeks([In] int weeks);
        void AddYears([In] int years);
        void ChangeCalendarSystem([In] string value);
        void ChangeClock([In] string value);
        Calendar Clone();
        string DayAsPaddedString([In] int minDigits);
        string DayAsString();
        [DefaultOverload, Overload("DayOfWeekAsFullSoloString")]
        string DayOfWeekAsSoloString();
        [Overload("DayOfWeekAsSoloString")]
        string DayOfWeekAsSoloString([In] int idealLength);
        [DefaultOverload, Overload("DayOfWeekAsFullString")]
        string DayOfWeekAsString();
        [Overload("DayOfWeekAsString")]
        string DayOfWeekAsString([In] int idealLength);
        [Overload("EraAsFullString"), DefaultOverload]
        string EraAsString();
        [Overload("EraAsString")]
        string EraAsString([In] int idealLength);
        void FromDateTime([In] Windows.Foundation.DateTime value);
        string GetCalendarSystem();
        string GetClock();
        Windows.Foundation.DateTime GetDateTime();
        string HourAsPaddedString([In] int minDigits);
        string HourAsString();
        string MinuteAsPaddedString([In] int minDigits);
        string MinuteAsString();
        string MonthAsNumericString();
        string MonthAsPaddedNumericString([In] int minDigits);
        [DefaultOverload, Overload("MonthAsFullSoloString")]
        string MonthAsSoloString();
        [Overload("MonthAsSoloString")]
        string MonthAsSoloString([In] int idealLength);
        [Overload("MonthAsFullString"), DefaultOverload]
        string MonthAsString();
        [Overload("MonthAsString")]
        string MonthAsString([In] int idealLength);
        string NanosecondAsPaddedString([In] int minDigits);
        string NanosecondAsString();
        void Now();
        [Overload("PeriodAsFullString"), DefaultOverload]
        string PeriodAsString();
        [Overload("PeriodAsString")]
        string PeriodAsString([In] int idealLength);
        string SecondAsPaddedString([In] int minDigits);
        string SecondAsString();
        void SetDateTime([In] Windows.Foundation.DateTime value);
        void SetToMax();
        void SetToMin();
        void SetToNow();
        Windows.Foundation.DateTime ToDateTime();
        string YearAsPaddedString([In] int minDigits);
        string YearAsString();
        string YearAsTruncatedString([In] int remainingDigits);

        int Day { get; [param: In] set; }

        Windows.Globalization.DayOfWeek DayOfWeek { get; }

        int Era { get; [param: In] set; }

        int FirstDayInThisMonth { get; }

        int FirstEra { get; }

        int FirstHourInThisPeriod { get; }

        int FirstMonthInThisYear { get; }

        int FirstPeriodInThisDay { get; }

        int FirstYearInThisEra { get; }

        int Hour { get; [param: In] set; }

        IVectorView<string> Languages { get; }

        int LastDayInThisMonth { get; }

        int LastEra { get; }

        int LastHourInThisPeriod { get; }

        int LastMonthInThisYear { get; }

        int LastPeriodInThisDay { get; }

        int LastYearInThisEra { get; }

        Calendar MaxSupported { get; }

        Calendar MinSupported { get; }

        int Minute { get; [param: In] set; }

        int Month { get; [param: In] set; }

        int Nanosecond { get; [param: In] set; }

        int NumberOfDaysInThisMonth { get; }

        int NumberOfEras { get; }

        int NumberOfHoursInThisPeriod { get; }

        int NumberOfMonthsInThisYear { get; }

        int NumberOfPeriodsInThisDay { get; }

        int NumberOfYearsInThisEra { get; }

        string NumeralSystem { get; [param: In] set; }

        int Period { get; [param: In] set; }

        int Second { get; [param: In] set; }

        int Year { get; [param: In] set; }
    }
}

