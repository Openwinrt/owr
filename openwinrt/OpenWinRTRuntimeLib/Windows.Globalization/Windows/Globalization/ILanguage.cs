namespace Windows.Globalization
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0xea79a752, 0xf7c2, 0x4265, 0xb1, 0xbd, 0xc4, 0xde, 0xc4, 0xe4, 240, 0x80), Version(0x6020000), ExclusiveTo(typeof(Language))]
    internal interface ILanguage
    {
        string DisplayName { get; }

        string LanguageTag { get; }

        string NativeName { get; }

        string Script { get; }
    }
}

