namespace Windows.UI.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Devices.Input;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0xab4fa3d3, 0x129e, 0x4ed5, 0xa2, 0x4e, 0xb6, 0xb1, 240, 0xae, 0x35, 13), Version(0x6020000)]
    public interface IInternalCoreWindow
    {
        event TypedEventHandler<CoreWindow, ContextMenuRequestedEventArgs> ContextMenuRequested;

        event TypedEventHandler<CoreWindow, CoreWindowEventArgs> ThemeChanged;

        event TypedEventHandler<CoreWindow, ViewStateChangedEventArgs> ViewStateChanged;

        Windows.Devices.Input.MouseDevice MouseDevice { get; }
    }
}

