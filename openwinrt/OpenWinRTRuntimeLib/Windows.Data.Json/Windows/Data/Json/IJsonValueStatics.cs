namespace Windows.Data.Json
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(JsonValue)), Windows.Foundation.Metadata.Guid(0x5f6b544a, 0x2f53, 0x48e1, 0x91, 0xa3, 0xf7, 0x8b, 80, 0xa6, 0x34, 0x5c), WebHostHidden, Version(0x6020000)]
    internal interface IJsonValueStatics
    {
        JsonValue CreateBooleanValue([In] bool input);
        JsonValue CreateNumberValue([In] double input);
        JsonValue CreateStringValue([In] string input);
        JsonValue Parse([In] string input);
        bool TryParse([In] string input, out JsonValue result);
    }
}

