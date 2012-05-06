namespace Windows.UI.Xaml.Automation.Provider
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Guid(0x6a4977c1, 0x830d, 0x42d2, 0xbf, 0x62, 4, 0x2e, 0xbd, 0xde, 0xcc, 0x19)]
    public interface ISelectionItemProvider
    {
        void AddToSelection();
        void RemoveFromSelection();
        void Select();

        bool IsSelected { get; }

        IRawElementProviderSimple SelectionContainer { get; }
    }
}

