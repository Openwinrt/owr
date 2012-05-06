namespace Windows.UI.ViewManagement
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class InputPaneVisibilityEventArgs : IInputPaneVisibilityEventArgs
    {
        public bool EnsuredFocusedElementInView { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Rect OccludedRect { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.ViewManagement.IInputPaneVisibilityEventArgs.EnsuredFocusedElementInView { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Rect Windows.UI.ViewManagement.IInputPaneVisibilityEventArgs.OccludedRect { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

