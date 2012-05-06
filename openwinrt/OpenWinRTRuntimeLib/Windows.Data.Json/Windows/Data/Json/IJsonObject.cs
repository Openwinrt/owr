namespace Windows.Data.Json
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(JsonObject)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x64e24dd, 0x29c2, 0x4f83, 0x9a, 0xc1, 0x9e, 0xe1, 0x15, 120, 190, 0xb3), Version(0x6020000)]
    internal interface IJsonObject : IJsonValue
    {
        JsonArray GetNamedArray([In] string name);
        bool GetNamedBoolean([In] string name);
        double GetNamedNumber([In] string name);
        JsonObject GetNamedObject([In] string name);
        string GetNamedString([In] string name);
        JsonValue GetNamedValue([In] string name);
        void SetNamedValue([In] string name, [In] IJsonValue value);
    }
}

