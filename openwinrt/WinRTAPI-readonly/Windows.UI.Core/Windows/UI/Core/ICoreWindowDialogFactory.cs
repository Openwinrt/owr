namespace Windows.UI.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(CoreWindowDialog)), WebHostHidden, Windows.Foundation.Metadata.Guid(0xcfb2a855, 0x1c59, 0x4b13, 0xb1, 0xe5, 0x16, 0xe2, 0x98, 5, 0xf7, 0xc4)]
    internal interface ICoreWindowDialogFactory
    {
        CoreWindowDialog CreateWithTitle([In] string title);
    }
}

