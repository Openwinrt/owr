namespace Windows.Media.Devices
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class KeypadPressedEventArgs : IKeypadPressedEventArgs
    {
        public Windows.Media.Devices.TelephonyKey TelephonyKey { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Media.Devices.TelephonyKey Windows.Media.Devices.IKeypadPressedEventArgs.TelephonyKey { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

