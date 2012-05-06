namespace Windows.UI.WebUI
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.ApplicationModel;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x509c429c, 0x78e2, 0x4883, 0xab, 200, 0x89, 0x60, 220, 0xde, 0x1b, 0x5c), Version(0x6020000)]
    public delegate void SuspendingEventHandler([In] object sender, [In] ISuspendingEventArgs e);
}

