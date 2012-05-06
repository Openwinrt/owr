namespace Windows.Globalization.Fonts
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xfcaeac67, 0x4e77, 0x49c7, 0xb8, 0x56, 0xdd, 0xe9, 0x34, 0xfc, 0x73, 0x5b), ExclusiveTo(typeof(LanguageFontGroup))]
    internal interface ILanguageFontGroupFactory
    {
        LanguageFontGroup CreateLanguageFontGroup([In] string languageTag);
    }
}

