namespace Windows.UI.ApplicationSettings
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xb1cd0932, 0x4570, 0x4c69, 0x8d, 0x38, 0x89, 0x44, 0x65, 0x61, 0xac, 0xe0), ExclusiveTo(typeof(SettingsPane)), Version(0x6020000)]
    internal interface ISettingsPane
    {
        event TypedEventHandler<SettingsPane, SettingsPaneCommandsRequestedEventArgs> CommandsRequested;
    }
}

