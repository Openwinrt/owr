namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Devices.Input;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Windows.Foundation.Metadata.Guid(0xa099e6be, 0xe624, 0x459a, 0xbb, 0x1d, 0xe0, 0x5c, 0x73, 0xe2, 0xcc, 0x66), Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(TappedRoutedEventArgs))]
    internal interface ITappedRoutedEventArgs
    {
        Point GetPosition([In] UIElement relativeTo);

        bool Handled { get; [param: In] set; }

        Windows.Devices.Input.PointerDeviceType PointerDeviceType { get; }
    }
}

