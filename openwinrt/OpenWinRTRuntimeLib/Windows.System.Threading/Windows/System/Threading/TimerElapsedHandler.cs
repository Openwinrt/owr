namespace Windows.System.Threading
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xfaaea667, 0xfbeb, 0x49cb, 0xad, 0xb2, 0x71, 0x18, 0x4c, 0x55, 110, 0x43), WebHostHidden]
    public delegate void TimerElapsedHandler([In] ThreadPoolTimer timer);
}

