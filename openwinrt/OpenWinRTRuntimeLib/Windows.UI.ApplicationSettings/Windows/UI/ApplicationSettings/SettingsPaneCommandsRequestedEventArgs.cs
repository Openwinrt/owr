namespace Windows.UI.ApplicationSettings
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class SettingsPaneCommandsRequestedEventArgs : ISettingsPaneCommandsRequestedEventArgs
    {
        public SettingsPaneCommandsRequest Request { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SettingsPaneCommandsRequest Windows.UI.ApplicationSettings.ISettingsPaneCommandsRequestedEventArgs.Request { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

