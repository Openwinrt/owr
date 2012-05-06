namespace Windows.Globalization
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(Calendar)), Windows.Foundation.Metadata.Guid(0x83f58412, 0xe56b, 0x4c75, 0xa6, 110, 15, 0x63, 0xd5, 0x77, 0x58, 0xa6), Version(0x6020000)]
    internal interface ICalendarFactory
    {
        Calendar CreateCalendar([In] IIterable<string> languages, [In] string calendar, [In] string clock);
        Calendar CreateCalendarDefaultCalendarAndClock([In] IIterable<string> languages);
    }
}

