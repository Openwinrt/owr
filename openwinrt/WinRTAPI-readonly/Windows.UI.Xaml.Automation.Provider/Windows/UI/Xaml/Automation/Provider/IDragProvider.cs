namespace Windows.UI.Xaml.Automation.Provider
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Guid(0x2e7786a9, 0x7ffc, 0x4f57, 0xb9, 0x65, 30, 0xf1, 0xf3, 0x73, 0xf5, 70)]
    public interface IDragProvider
    {
        IRawElementProviderSimple[] GetGrabbedItems();

        string DropEffect { get; }

        string[] DropEffects { get; }

        bool IsGrabbed { get; }
    }
}

