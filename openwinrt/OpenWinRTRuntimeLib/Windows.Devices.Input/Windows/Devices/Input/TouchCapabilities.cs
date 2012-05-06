namespace Windows.Devices.Input
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Activatable(0x6020000)]
    public sealed class TouchCapabilities : ITouchCapabilities
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public TouchCapabilities();

        public uint Contacts { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int TouchPresent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Devices.Input.ITouchCapabilities.Contacts { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Devices.Input.ITouchCapabilities.TouchPresent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

