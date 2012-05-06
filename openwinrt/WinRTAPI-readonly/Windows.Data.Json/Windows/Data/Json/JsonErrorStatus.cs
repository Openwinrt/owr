namespace Windows.Data.Json
{
    using System;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000)]
    public enum JsonErrorStatus
    {
        Unknown,
        InvalidJsonString,
        InvalidJsonNumber,
        JsonValueNotFound,
        ImplementationLimit
    }
}

