namespace Windows.UI.ApplicationSettings
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(SettingsPane)), Guid(0x1c6a52c5, 0xff19, 0x471b, 0xba, 0x6b, 0xf8, 0xf3, 0x56, 0x94, 0xad, 0x9a)]
    internal interface ISettingsPaneStatics
    {
        SettingsPane GetForCurrentView();
        void Show();
    }
}

