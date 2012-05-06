namespace Windows.System.Threading
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x923c402e, 0x4721, 0x440e, 0x9d, 0xda, 0x55, 0xb6, 0xf2, 0xe0, 0x77, 0x10), WebHostHidden]
    public delegate void WaitHandler([In] ThreadPoolWaitHandle waitHandle, [In] bool timedOut);
}

