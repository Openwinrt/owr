namespace Windows.UI.Xaml.Automation.Provider
{
    using System;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation;

    [Version(0x6020000), Guid(0x93b88290, 0x656f, 0x44f7, 0xae, 0xaf, 120, 0xb8, 0xf9, 0x44, 0xd0, 0x62), WebHostHidden]
    public interface IToggleProvider
    {
        void Toggle();

        Windows.UI.Xaml.Automation.ToggleState ToggleState { get; }
    }
}

