namespace Windows.UI.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.System;

    [Version(0x6020000), WebHostHidden]
    public sealed class KeyEventArgs : IKeyEventArgs, ICoreWindowEventArgs
    {
        public bool Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public CorePhysicalKeyStatus KeyStatus { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.System.VirtualKey VirtualKey { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Core.ICoreWindowEventArgs.Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public CorePhysicalKeyStatus Windows.UI.Core.IKeyEventArgs.KeyStatus { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.System.VirtualKey Windows.UI.Core.IKeyEventArgs.VirtualKey { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

