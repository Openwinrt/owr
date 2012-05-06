namespace Windows.UI.ApplicationSettings
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x205f5d24, 0x1b48, 0x4629, 0xa6, 0xca, 0x2f, 0xdf, 0xed, 0xaf, 0xb7, 0x5d), ExclusiveTo(typeof(SettingsPaneCommandsRequestedEventArgs))]
    internal interface ISettingsPaneCommandsRequestedEventArgs
    {
        SettingsPaneCommandsRequest Request { get; }
    }
}

