namespace Windows.Devices.Input
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Activatable(0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class MouseCapabilities : IMouseCapabilities
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public MouseCapabilities();

        public int HorizontalWheelPresent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int MousePresent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint NumberOfButtons { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int SwapButtons { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int VerticalWheelPresent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Devices.Input.IMouseCapabilities.HorizontalWheelPresent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Devices.Input.IMouseCapabilities.MousePresent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Devices.Input.IMouseCapabilities.NumberOfButtons { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Devices.Input.IMouseCapabilities.SwapButtons { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Devices.Input.IMouseCapabilities.VerticalWheelPresent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

