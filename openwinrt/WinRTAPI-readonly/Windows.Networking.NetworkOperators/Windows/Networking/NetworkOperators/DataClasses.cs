namespace Windows.Networking.NetworkOperators
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Flags]
    public enum DataClasses : uint
    {
        Cdma1xEvdo = 0x20000,
        Cdma1xEvdoRevA = 0x40000,
        Cdma1xEvdoRevB = 0x200000,
        Cdma1xEvdv = 0x80000,
        Cdma1xRtt = 0x10000,
        Cdma3xRtt = 0x100000,
        CdmaUmb = 0x400000,
        Custom = 0x80000000,
        Edge = 2,
        Gprs = 1,
        Hsdpa = 8,
        Hsupa = 0x10,
        LteAdvanced = 0x20,
        None = 0,
        Umts = 4
    }
}

