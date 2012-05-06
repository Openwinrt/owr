namespace Windows.UI.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000)]
    public sealed class InputEnabledEventArgs : IInputEnabledEventArgs, ICoreWindowEventArgs
    {
        public bool Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool InputEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Core.ICoreWindowEventArgs.Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Core.IInputEnabledEventArgs.InputEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

