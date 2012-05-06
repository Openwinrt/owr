namespace Windows.UI.ViewManagement
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Static(typeof(IInputPaneStatics), 0x6020000)]
    public sealed class InputPane : IInputPane
    {
        public event TypedEventHandler<InputPane, InputPaneVisibilityEventArgs> Hiding;

        public event TypedEventHandler<InputPane, InputPaneVisibilityEventArgs> Showing;

        public event TypedEventHandler<InputPane, InputPaneVisibilityEventArgs> Windows.UI.ViewManagement.IInputPane.Hiding;

        public event TypedEventHandler<InputPane, InputPaneVisibilityEventArgs> Windows.UI.ViewManagement.IInputPane.Showing;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static InputPane GetForCurrentView();

        public Rect OccludedRect { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Rect Windows.UI.ViewManagement.IInputPane.OccludedRect { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

