namespace Windows.Globalization
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(Language)), Windows.Foundation.Metadata.Guid(0x9b0252ac, 0xc27, 0x44f8, 0xb7, 0x92, 0x97, 0x93, 0xfb, 0x66, 0xc6, 0x3e), Version(0x6020000)]
    internal interface ILanguageFactory
    {
        Language CreateLanguage([In] string languageTag);
    }
}

