namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.System;
    using Windows.UI.Core;
    using Windows.UI.Xaml;

    [WebHostHidden, Version(0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class KeyEventArgs : RoutedEventArgs, Windows.UI.Xaml.Input.IKeyEventArgs
    {
        public bool Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public VirtualKey Key { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public CorePhysicalKeyStatus KeyStatus { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Input.IKeyEventArgs.Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public VirtualKey Windows.UI.Xaml.Input.IKeyEventArgs.Key { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public CorePhysicalKeyStatus Windows.UI.Xaml.Input.IKeyEventArgs.KeyStatus { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

