namespace Windows.UI.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden]
    public sealed class WindowActivatedEventArgs : IWindowActivatedEventArgs, ICoreWindowEventArgs
    {
        public bool Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public CoreWindowActivationState WindowActivationState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Core.ICoreWindowEventArgs.Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public CoreWindowActivationState Windows.UI.Core.IWindowActivatedEventArgs.WindowActivationState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

