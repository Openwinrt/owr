namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xe7ecd720, 0xf2f4, 0x4a2d, 0x92, 14, 0x17, 10, 0x2f, 0x48, 0x2a, 0x27)]
    public delegate void DataProviderHandler([In] DataProviderRequest request);
}

