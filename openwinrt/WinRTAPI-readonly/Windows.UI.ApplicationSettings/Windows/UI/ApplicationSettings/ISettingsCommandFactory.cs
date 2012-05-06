namespace Windows.UI.ApplicationSettings
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Popups;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x68e15b33, 0x1c83, 0x433a, 170, 90, 0xce, 0xee, 0xa5, 0xbd, 0x47, 100), ExclusiveTo(typeof(SettingsCommand))]
    internal interface ISettingsCommandFactory
    {
        [DefaultOverload, Overload("CreateSettingsCommand")]
        SettingsCommand Create([In, Variant] object settingsCommandId, [In] string label, [In] UICommandInvokedHandler handler);
    }
}

