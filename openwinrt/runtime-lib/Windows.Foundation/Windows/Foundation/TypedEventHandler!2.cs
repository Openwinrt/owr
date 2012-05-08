namespace Windows.Foundation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x9de1c534, 0x6ae1, 0x11e0, 0x84, 0xe1, 0x18, 0xa9, 5, 0xbc, 0xc5, 0x3f)]
    public delegate void TypedEventHandler<TSender, TResult>([In] TSender sender, [In] TResult args);
}

