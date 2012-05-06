namespace Windows.UI.Xaml.Automation.Provider
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation;

    [Windows.Foundation.Metadata.Guid(0x48c243f8, 0x78b1, 0x44a0, 0xac, 0x5f, 0x75, 7, 0x57, 0xbc, 0xde, 60), WebHostHidden, Version(0x6020000)]
    public interface IDockProvider
    {
        void SetDockPosition([In] Windows.UI.Xaml.Automation.DockPosition dockPosition);

        Windows.UI.Xaml.Automation.DockPosition DockPosition { get; }
    }
}

