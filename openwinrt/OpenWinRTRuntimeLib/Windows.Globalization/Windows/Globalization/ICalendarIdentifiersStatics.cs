namespace Windows.Globalization
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(CalendarIdentifiers)), Guid(0x80653f68, 0x2cb2, 0x4c1f, 0xb5, 0x90, 240, 0xf5, 0x2b, 0xf4, 0xfd, 0x1a), Version(0x6020000)]
    internal interface ICalendarIdentifiersStatics
    {
        string Gregorian { get; }

        string Hebrew { get; }

        string Hijri { get; }

        string Japanese { get; }

        string Julian { get; }

        string Korean { get; }

        string Taiwan { get; }

        string Thai { get; }

        string UmAlQura { get; }
    }
}

