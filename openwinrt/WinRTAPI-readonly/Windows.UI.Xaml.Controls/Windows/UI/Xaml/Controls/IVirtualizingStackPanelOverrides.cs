namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(VirtualizingStackPanel)), Windows.Foundation.Metadata.Guid(0xcbe6f72c, 0x2892, 0x46d1, 0x98, 0x7f, 0x58, 0xca, 0x10, 0x81, 240, 0x40)]
    internal interface IVirtualizingStackPanelOverrides
    {
        void OnCleanUpVirtualizedItem([In] CleanUpVirtualizedItemEventArgs e);
    }
}

