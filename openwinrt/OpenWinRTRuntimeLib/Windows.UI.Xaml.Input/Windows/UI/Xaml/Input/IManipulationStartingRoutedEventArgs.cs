namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(ManipulationStartingRoutedEventArgs)), Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x18d636b7, 0x53a4, 0x4c15, 0xa4, 0x98, 0xf3, 0xa9, 0xca, 0x21, 0x2a, 0x42)]
    internal interface IManipulationStartingRoutedEventArgs
    {
        UIElement Container { get; [param: In] set; }

        bool Handled { get; [param: In] set; }

        ManipulationModes Mode { get; [param: In] set; }

        ManipulationPivot Pivot { get; [param: In] set; }
    }
}

