namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Devices.Input;
    using Windows.Foundation.Metadata;
    using Windows.UI.Input;
    using Windows.UI.Xaml;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x246a91a9, 0xca43, 0x4c0b, 0xac, 0xef, 0x81, 0xe8, 0xb8, 20, 0x75, 0x20), ExclusiveTo(typeof(ManipulationInertiaStartingRoutedEventArgs))]
    internal interface IManipulationInertiaStartingRoutedEventArgs
    {
        UIElement Container { get; }

        ManipulationDelta Cumulative { get; }

        ManipulationDelta Delta { get; }

        InertiaExpansionBehavior ExpansionBehavior { get; [param: In] set; }

        bool Handled { get; [param: In] set; }

        Windows.Devices.Input.PointerDeviceType PointerDeviceType { get; }

        InertiaRotationBehavior RotationBehavior { get; [param: In] set; }

        InertiaTranslationBehavior TranslationBehavior { get; [param: In] set; }

        ManipulationVelocities Velocities { get; }
    }
}

