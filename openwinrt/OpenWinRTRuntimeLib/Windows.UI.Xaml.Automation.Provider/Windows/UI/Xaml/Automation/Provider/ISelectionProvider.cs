namespace Windows.UI.Xaml.Automation.Provider
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x1f018fca, 0xb944, 0x4395, 0x8d, 0xe1, 0x88, 0xf6, 0x74, 0xaf, 0x51, 0xd3), Version(0x6020000), WebHostHidden]
    public interface ISelectionProvider
    {
        IRawElementProviderSimple[] GetSelection();

        bool CanSelectMultiple { get; }

        bool IsSelectionRequired { get; }
    }
}

