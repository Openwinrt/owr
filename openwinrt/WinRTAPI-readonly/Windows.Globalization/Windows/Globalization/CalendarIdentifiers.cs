namespace Windows.Globalization
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Static(typeof(ICalendarIdentifiersStatics), 0x6020000)]
    public static class CalendarIdentifiers
    {
        public static string Gregorian { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Hebrew { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Hijri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Japanese { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Julian { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Korean { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Taiwan { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Thai { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string UmAlQura { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

