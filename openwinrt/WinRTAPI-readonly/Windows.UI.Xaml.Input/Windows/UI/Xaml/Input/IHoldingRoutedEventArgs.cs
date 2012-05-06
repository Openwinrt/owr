namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Devices.Input;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Input;
    using Windows.UI.Xaml;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0xc246ff23, 0xd80d, 0x44de, 0x8d, 0xb9, 13, 0x81, 0x5e, 0x26, 0x9a, 0xc0), ExclusiveTo(typeof(HoldingRoutedEventArgs))]
    internal interface IHoldingRoutedEventArgs
    {
        Point GetPosition([In] UIElement relativeTo);

        bool Handled { get; [param: In] set; }

        Windows.UI.Input.HoldingState HoldingState { get; }

        Windows.Devices.Input.PointerDeviceType PointerDeviceType { get; }
    }
}

