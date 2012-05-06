namespace Windows.Data.Json
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x2289f159, 0x54de, 0x45d8, 0xab, 0xcc, 0x22, 0x60, 0x3f, 160, 0x66, 160), ExclusiveTo(typeof(JsonObject)), WebHostHidden]
    internal interface IJsonObjectStatics
    {
        JsonObject Parse([In] string input);
        bool TryParse([In] string input, out JsonObject result);
    }
}

