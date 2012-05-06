namespace Windows.UI.ApplicationSettings
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Static(typeof(ISettingsPaneStatics), 0x6020000)]
    public sealed class SettingsPane : ISettingsPane
    {
        public event TypedEventHandler<SettingsPane, SettingsPaneCommandsRequestedEventArgs> CommandsRequested;

        public event TypedEventHandler<SettingsPane, SettingsPaneCommandsRequestedEventArgs> Windows.UI.ApplicationSettings.ISettingsPane.CommandsRequested;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static SettingsPane GetForCurrentView();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void Show();
    }
}

