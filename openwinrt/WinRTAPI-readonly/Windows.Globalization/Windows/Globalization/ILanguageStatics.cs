namespace Windows.Globalization
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xb23cd557, 0x865, 0x46d4, 0x89, 0xb8, 0xd5, 0x9b, 0xe8, 0x99, 15, 13), ExclusiveTo(typeof(Language))]
    internal interface ILanguageStatics
    {
        bool IsWellFormed([In] string languageTag);

        string CurrentInputMethodLanguageTag { get; }
    }
}

