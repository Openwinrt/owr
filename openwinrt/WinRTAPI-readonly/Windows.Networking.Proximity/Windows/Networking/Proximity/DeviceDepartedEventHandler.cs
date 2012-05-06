namespace Windows.Networking.Proximity
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xefa9da69, 0xf6e2, 0x49c9, 0xa4, 0x9e, 0x8e, 15, 0xc5, 0x8f, 0xb9, 0x11)]
    public delegate void DeviceDepartedEventHandler([In] ProximityDevice sender);
}

