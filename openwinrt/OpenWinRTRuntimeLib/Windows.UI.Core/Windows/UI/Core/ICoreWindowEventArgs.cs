namespace Windows.UI.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0x272b1ef3, 0xc633, 0x4da5, 0xa2, 0x6c, 0xc6, 0xd0, 0xf5, 0x6b, 0x29, 0xda)]
    public interface ICoreWindowEventArgs
    {
        bool Handled { get; [param: In] set; }
    }
}

