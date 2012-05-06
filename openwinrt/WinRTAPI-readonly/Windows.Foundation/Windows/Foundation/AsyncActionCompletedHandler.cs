namespace Windows.Foundation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xa4ed5c81, 0x76c9, 0x40bd, 0x8b, 230, 0xb1, 0xd9, 15, 0xb2, 10, 0xe7)]
    public delegate void AsyncActionCompletedHandler([In] IAsyncAction asyncInfo, [In] AsyncStatus asyncStatus);
}

