namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Devices.Input;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Input;
    using Windows.UI.Xaml;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0x400d5794, 0x4c6f, 0x491d, 130, 0xd6, 0x35, 0x17, 0x10, 0x93, 0x99, 0xc6), ExclusiveTo(typeof(ManipulationDeltaRoutedEventArgs)), Version(0x6020000)]
    internal interface IManipulationDeltaRoutedEventArgs
    {
        void Complete();

        UIElement Container { get; }

        ManipulationDelta Cumulative { get; }

        ManipulationDelta Delta { get; }

        bool Handled { get; [param: In] set; }

        bool IsInertial { get; }

        Windows.Devices.Input.PointerDeviceType PointerDeviceType { get; }

        Point Position { get; }

        ManipulationVelocities Velocities { get; }
    }
}

