namespace Windows.Foundation
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum PropertyType
    {
        Boolean = 11,
        BooleanArray = 0x40b,
        Char16 = 10,
        Char16Array = 0x40a,
        DateTime = 14,
        DateTimeArray = 0x40e,
        Double = 9,
        DoubleArray = 0x409,
        Empty = 0,
        Guid = 0x10,
        GuidArray = 0x410,
        Inspectable = 13,
        InspectableArray = 0x40d,
        Int16 = 2,
        Int16Array = 0x402,
        Int32 = 4,
        Int32Array = 0x404,
        Int64 = 6,
        Int64Array = 0x406,
        OtherType = 20,
        OtherTypeArray = 0x414,
        Point = 0x11,
        PointArray = 0x411,
        Rect = 0x13,
        RectArray = 0x413,
        Single = 8,
        SingleArray = 0x408,
        Size = 0x12,
        SizeArray = 0x412,
        String = 12,
        StringArray = 0x40c,
        TimeSpan = 15,
        TimeSpanArray = 0x40f,
        UInt16 = 3,
        UInt16Array = 0x403,
        UInt32 = 5,
        UInt32Array = 0x405,
        UInt64 = 7,
        UInt64Array = 0x407,
        UInt8 = 1,
        UInt8Array = 0x401
    }
}

