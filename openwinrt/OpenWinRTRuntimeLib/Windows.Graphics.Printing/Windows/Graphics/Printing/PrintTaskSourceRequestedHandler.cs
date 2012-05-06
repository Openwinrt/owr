namespace Windows.Graphics.Printing
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x6c109fa8, 0x5cb6, 0x4b3a, 0x86, 0x63, 0xf3, 0x9c, 0xb0, 0x2d, 0xc9, 180)]
    public delegate void PrintTaskSourceRequestedHandler([In] PrintTaskSourceRequestedArgs args);
}

