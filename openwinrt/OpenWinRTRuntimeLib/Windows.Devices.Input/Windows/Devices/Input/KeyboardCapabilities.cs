namespace Windows.Devices.Input
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Activatable(0x6020000), Version(0x6020000)]
    public sealed class KeyboardCapabilities : IKeyboardCapabilities
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public KeyboardCapabilities();

        public int KeyboardPresent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Devices.Input.IKeyboardCapabilities.KeyboardPresent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

