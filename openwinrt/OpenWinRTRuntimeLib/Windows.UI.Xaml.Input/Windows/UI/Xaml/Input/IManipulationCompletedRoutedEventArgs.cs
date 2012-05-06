namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Devices.Input;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Input;
    using Windows.UI.Xaml;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(ManipulationCompletedRoutedEventArgs)), Windows.Foundation.Metadata.Guid(0xb5ad9b23, 0x2f41, 0x498e, 0x83, 0x19, 1, 0x5e, 0xe8, 0xa7, 0x53, 70)]
    internal interface IManipulationCompletedRoutedEventArgs
    {
        UIElement Container { get; }

        ManipulationDelta Cumulative { get; }

        bool Handled { get; [param: In] set; }

        bool IsInertial { get; }

        Windows.Devices.Input.PointerDeviceType PointerDeviceType { get; }

        Point Position { get; }

        ManipulationVelocities Velocities { get; }
    }
}

