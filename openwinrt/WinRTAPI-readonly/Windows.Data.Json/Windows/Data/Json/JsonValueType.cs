namespace Windows.Data.Json
{
    using System;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000)]
    public enum JsonValueType
    {
        Null,
        Boolean,
        Number,
        String,
        Array,
        Object
    }
}

