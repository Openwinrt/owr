namespace Windows.System.Threading
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x1d1a8b8b, 0xfa66, 0x414f, 0x9c, 0xbd, 0xb6, 0x5f, 0xc9, 0x9d, 0x17, 250), WebHostHidden, Version(0x6020000)]
    public delegate void WorkItemHandler([In] IAsyncAction operation);
}

