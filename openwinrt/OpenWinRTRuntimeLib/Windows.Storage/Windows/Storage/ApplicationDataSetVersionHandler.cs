namespace Windows.Storage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xa05791e6, 0xcc9f, 0x4687, 0xac, 0xab, 0xa3, 100, 0xfd, 120, 0x54, 0x63)]
    public delegate void ApplicationDataSetVersionHandler([In] SetVersionRequest setVersionRequest);
}

