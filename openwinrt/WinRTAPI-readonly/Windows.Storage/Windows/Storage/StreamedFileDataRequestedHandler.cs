namespace Windows.Storage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xfef6a824, 0x2fe1, 0x4d07, 0xa3, 0x5b, 0xb7, 0x7c, 80, 0xb5, 0xf4, 0xcc), Version(0x6020000)]
    public delegate void StreamedFileDataRequestedHandler([In] StreamedFileDataRequest stream);
}

