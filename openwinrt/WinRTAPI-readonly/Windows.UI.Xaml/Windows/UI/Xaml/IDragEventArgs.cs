namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.ApplicationModel.DataTransfer;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xb440c7c3, 0x2b4, 0x4980, 0x93, 0x42, 0x25, 0xda, 0xe1, 0xc0, 0xf1, 0x88), WebHostHidden, ExclusiveTo(typeof(DragEventArgs))]
    internal interface IDragEventArgs
    {
        Point GetPosition([In] UIElement relativeTo);

        DataPackage Data { get; [param: In] set; }

        bool Handled { get; [param: In] set; }
    }
}

