namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Devices.Input;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Input;
    using Windows.UI.Xaml;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x5db1aa05, 0x9f80, 0x48b6, 0xae, 0x6c, 0x4f, 0x11, 0x9d, 0xe8, 0xff, 0x13), WebHostHidden, ExclusiveTo(typeof(ManipulationStartedRoutedEventArgs))]
    internal interface IManipulationStartedRoutedEventArgs
    {
        void Complete();

        UIElement Container { get; }

        ManipulationDelta Cumulative { get; }

        bool Handled { get; [param: In] set; }

        Windows.Devices.Input.PointerDeviceType PointerDeviceType { get; }

        Point Position { get; }
    }
}

