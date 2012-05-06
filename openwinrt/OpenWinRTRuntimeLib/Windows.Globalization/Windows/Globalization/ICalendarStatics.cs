namespace Windows.Globalization
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(Calendar)), Windows.Foundation.Metadata.Guid(0xa88c0a03, 0xfdf2, 0x4800, 0xb8, 0xa5, 0xd9, 0xcd, 60, 0xd4, 0x44, 0x29), Version(0x6020000)]
    internal interface ICalendarStatics
    {
        int Compare([In] Calendar left, [In] Calendar right);
    }
}

