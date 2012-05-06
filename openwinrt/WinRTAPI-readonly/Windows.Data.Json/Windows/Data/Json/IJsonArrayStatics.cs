namespace Windows.Data.Json
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xdb1434a9, 0xe164, 0x499f, 0x93, 0xe2, 0x8a, 0x8f, 0x49, 0xbb, 0x90, 0xba), Version(0x6020000), ExclusiveTo(typeof(JsonArray)), WebHostHidden]
    internal interface IJsonArrayStatics
    {
        JsonArray Parse([In] string input);
        bool TryParse([In] string input, out JsonArray result);
    }
}

