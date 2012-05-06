namespace Windows.Data.Json
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0xa3219ecb, 0xf0b3, 0x4dcd, 190, 0xee, 0x19, 0xd4, 140, 0xd3, 0xed, 30), WebHostHidden, Version(0x6020000)]
    public interface IJsonValue
    {
        JsonArray GetArray();
        bool GetBoolean();
        double GetNumber();
        JsonObject GetObject();
        string GetString();
        string Stringify();

        JsonValueType ValueType { get; }
    }
}

