namespace Windows.Globalization
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(ApplicationPreferences)), Windows.Foundation.Metadata.Guid(0x75b40847, 0xa4c, 0x4a92, 0x95, 0x65, 0xfd, 0x63, 0xc9, 0x5f, 0x7a, 0xed)]
    internal interface IApplicationPreferencesStatics
    {
        string PreferredLanguage { get; [param: In] set; }
    }
}

