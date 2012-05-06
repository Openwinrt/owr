namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(VirtualizingPanel)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xbe19f839, 0xcbd0, 0x43e9, 0xa5, 0xd0, 11, 0xdb, 160, 0xff, 0xbd, 0x38), WebHostHidden]
    internal interface IVirtualizingPanelFactory
    {
        VirtualizingPanel CreateInstance([In] object outer, out object inner);
    }
}

