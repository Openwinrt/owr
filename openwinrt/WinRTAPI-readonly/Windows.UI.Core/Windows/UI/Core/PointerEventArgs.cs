namespace Windows.UI.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.System;
    using Windows.UI.Input;

    [WebHostHidden, Version(0x6020000)]
    public sealed class PointerEventArgs : IPointerEventArgs, ICoreWindowEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVector<PointerPoint> GetIntermediatePoints();

        public PointerPoint CurrentPoint { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public VirtualKeyModifiers KeyModifiers { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Core.ICoreWindowEventArgs.Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PointerPoint Windows.UI.Core.IPointerEventArgs.CurrentPoint { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public VirtualKeyModifiers Windows.UI.Core.IPointerEventArgs.KeyModifiers { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

