namespace Windows.UI.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.System;

    [WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class AcceleratorKeyEventArgs : IAcceleratorKeyEventArgs, ICoreWindowEventArgs
    {
        public CoreAcceleratorKeyEventType EventType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public CorePhysicalKeyStatus KeyStatus { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.System.VirtualKey VirtualKey { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public CoreAcceleratorKeyEventType Windows.UI.Core.IAcceleratorKeyEventArgs.EventType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public CorePhysicalKeyStatus Windows.UI.Core.IAcceleratorKeyEventArgs.KeyStatus { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.System.VirtualKey Windows.UI.Core.IAcceleratorKeyEventArgs.VirtualKey { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Core.ICoreWindowEventArgs.Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

