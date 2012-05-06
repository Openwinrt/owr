namespace Windows.UI.ApplicationSettings
{
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x44df23ae, 0x5d6e, 0x4068, 0xa1, 0x68, 0xf4, 0x76, 0x43, 0x18, 0x21, 20), ExclusiveTo(typeof(SettingsPaneCommandsRequest))]
    internal interface ISettingsPaneCommandsRequest
    {
        IVector<SettingsCommand> ApplicationCommands { get; }
    }
}

