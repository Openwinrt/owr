namespace Windows.UI.ApplicationSettings
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class SettingsPaneCommandsRequest : ISettingsPaneCommandsRequest
    {
        public IVector<SettingsCommand> ApplicationCommands { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<SettingsCommand> Windows.UI.ApplicationSettings.ISettingsPaneCommandsRequest.ApplicationCommands { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

