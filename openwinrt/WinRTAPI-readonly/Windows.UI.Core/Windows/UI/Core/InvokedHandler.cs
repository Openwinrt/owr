namespace Windows.UI.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x30fc51a4, 0x9976, 0x4631, 0xa3, 0xb3, 0x85, 0x98, 0x7a, 50, 0xfd, 0xa9)]
    public delegate void InvokedHandler([In] object sender, [In] InvokedHandlerArgs e);
}

