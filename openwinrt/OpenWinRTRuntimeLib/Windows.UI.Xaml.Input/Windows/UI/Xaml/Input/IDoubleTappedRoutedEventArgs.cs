namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Devices.Input;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(DoubleTappedRoutedEventArgs)), Windows.Foundation.Metadata.Guid(0xaf404424, 0x26df, 0x44f4, 0x87, 20, 0x93, 0x59, 0x24, 0x9b, 0x62, 0xd3), Version(0x6020000), WebHostHidden]
    internal interface IDoubleTappedRoutedEventArgs
    {
        Point GetPosition([In] UIElement relativeTo);

        bool Handled { get; [param: In] set; }

        Windows.Devices.Input.PointerDeviceType PointerDeviceType { get; }
    }
}

