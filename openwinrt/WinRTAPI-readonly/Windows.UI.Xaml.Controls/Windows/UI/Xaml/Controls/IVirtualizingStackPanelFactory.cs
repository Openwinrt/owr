namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x4114b4a, 0x523, 0x4411, 0xb2, 0xde, 0x51, 0x72, 0xf7, 0xe9, 0xee, 0x71), Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(VirtualizingStackPanel))]
    internal interface IVirtualizingStackPanelFactory
    {
        VirtualizingStackPanel CreateInstance([In] object outer, out object inner);
    }
}

