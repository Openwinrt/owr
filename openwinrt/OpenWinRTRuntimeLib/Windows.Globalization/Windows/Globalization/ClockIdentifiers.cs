namespace Windows.Globalization
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Static(typeof(IClockIdentifiersStatics), 0x6020000), DualApiPartition(version=0x6020000), Version(0x6020000), Threading(ThreadingModel.Both)]
    public static class ClockIdentifiers
    {
        public static string TwelveHour { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string TwentyFourHour { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

