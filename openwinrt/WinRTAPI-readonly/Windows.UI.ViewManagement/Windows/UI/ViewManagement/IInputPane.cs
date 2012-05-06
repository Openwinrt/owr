namespace Windows.UI.ViewManagement
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x640ada70, 0x6f3, 0x4c87, 0xa6, 120, 0x98, 0x29, 0xc9, 0x12, 0x7c, 40), ExclusiveTo(typeof(InputPane))]
    internal interface IInputPane
    {
        event TypedEventHandler<InputPane, InputPaneVisibilityEventArgs> Hiding;

        event TypedEventHandler<InputPane, InputPaneVisibilityEventArgs> Showing;

        Rect OccludedRect { get; }
    }
}

