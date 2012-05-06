namespace Windows.Globalization.DateTimeFormatting
{
    using Windows.Foundation.Metadata;

    [Guid(0xbfcde7c0, 0xdf4c, 0x4a2e, 0x90, 0x12, 0xf4, 0x7d, 0xaf, 0x3f, 0x12, 0x12), ExclusiveTo(typeof(DateTimeFormatter)), Version(0x6020000)]
    internal interface IDateTimeFormatterStatics
    {
        DateTimeFormatter LongDate { get; }

        DateTimeFormatter LongTime { get; }

        DateTimeFormatter ShortDate { get; }

        DateTimeFormatter ShortTime { get; }
    }
}

