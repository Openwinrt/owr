namespace Windows.Devices.Input
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden]
    public sealed class MouseEventArgs : IMouseEventArgs
    {
        public Windows.Devices.Input.MouseDelta MouseDelta { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Devices.Input.MouseDelta Windows.Devices.Input.IMouseEventArgs.MouseDelta { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

