namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Devices.Input;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x6834869d, 0x7bd5, 0x4033, 0xb2, 0x37, 0x17, 0x2f, 0x79, 0xab, 0xe3, 0x93), ExclusiveTo(typeof(RightTappedRoutedEventArgs))]
    internal interface IRightTappedRoutedEventArgs
    {
        Point GetPosition([In] UIElement relativeTo);

        bool Handled { get; [param: In] set; }

        Windows.Devices.Input.PointerDeviceType PointerDeviceType { get; }
    }
}

