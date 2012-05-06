namespace Windows.UI.Xaml.Automation.Provider
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x1baa8b3d, 0x38cf, 0x415a, 0x85, 0xd3, 0x20, 0xe4, 0x3a, 14, 0xc1, 0xb1), WebHostHidden]
    public interface IWindowProvider
    {
        void Close();
        void SetVisualState([In] WindowVisualState state);
        bool WaitForInputIdle([In] int milliseconds);

        WindowInteractionState InteractionState { get; }

        bool IsModal { get; }

        bool IsTopmost { get; }

        bool Maximizable { get; }

        bool Minimizable { get; }

        WindowVisualState VisualState { get; }
    }
}

