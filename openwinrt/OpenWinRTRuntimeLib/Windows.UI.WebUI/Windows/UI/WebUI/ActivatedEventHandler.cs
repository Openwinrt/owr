namespace Windows.UI.WebUI
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.ApplicationModel.Activation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x50f1e730, 0xc5d1, 0x4b6b, 0x9a, 0xdb, 0x8a, 0x11, 0x75, 0x6b, 0xe2, 0x9c)]
    public delegate void ActivatedEventHandler([In] object sender, [In] IActivatedEventArgs eventArgs);
}

