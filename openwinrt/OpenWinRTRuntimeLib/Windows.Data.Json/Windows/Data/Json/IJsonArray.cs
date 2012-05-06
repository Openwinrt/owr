namespace Windows.Data.Json
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0x8c1ddb6, 0xcbd, 0x4a9a, 0xb5, 0xd3, 0x2f, 0x85, 0x2d, 0xc3, 0x7e, 0x81), ExclusiveTo(typeof(JsonArray)), Version(0x6020000)]
    internal interface IJsonArray : IJsonValue
    {
        JsonArray GetArrayAt([In] uint index);
        bool GetBooleanAt([In] uint index);
        double GetNumberAt([In] uint index);
        JsonObject GetObjectAt([In] uint index);
        string GetStringAt([In] uint index);
    }
}

