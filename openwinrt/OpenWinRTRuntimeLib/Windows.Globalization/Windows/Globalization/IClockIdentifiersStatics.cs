namespace Windows.Globalization
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ClockIdentifiers)), Version(0x6020000), Guid(0x523805bb, 0x12ec, 0x4f83, 0xbc, 0x31, 0xb1, 180, 0x37, 0x6b, 8, 8)]
    internal interface IClockIdentifiersStatics
    {
        string TwelveHour { get; }

        string TwentyFourHour { get; }
    }
}

