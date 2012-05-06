namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Devices.Input;
    using Windows.Foundation.Metadata;
    using Windows.UI.Input;
    using Windows.UI.Xaml;

    [Activatable(0x6020000), WebHostHidden, Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both)]
    public sealed class ManipulationInertiaStartingRoutedEventArgs : RoutedEventArgs, IManipulationInertiaStartingRoutedEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ManipulationInertiaStartingRoutedEventArgs();

        public UIElement Container { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ManipulationDelta Cumulative { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ManipulationDelta Delta { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public InertiaExpansionBehavior ExpansionBehavior { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Devices.Input.PointerDeviceType PointerDeviceType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public InertiaRotationBehavior RotationBehavior { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public InertiaTranslationBehavior TranslationBehavior { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ManipulationVelocities Velocities { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public UIElement Windows.UI.Xaml.Input.IManipulationInertiaStartingRoutedEventArgs.Container { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ManipulationDelta Windows.UI.Xaml.Input.IManipulationInertiaStartingRoutedEventArgs.Cumulative { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ManipulationDelta Windows.UI.Xaml.Input.IManipulationInertiaStartingRoutedEventArgs.Delta { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public InertiaExpansionBehavior Windows.UI.Xaml.Input.IManipulationInertiaStartingRoutedEventArgs.ExpansionBehavior { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Input.IManipulationInertiaStartingRoutedEventArgs.Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Devices.Input.PointerDeviceType Windows.UI.Xaml.Input.IManipulationInertiaStartingRoutedEventArgs.PointerDeviceType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public InertiaRotationBehavior Windows.UI.Xaml.Input.IManipulationInertiaStartingRoutedEventArgs.RotationBehavior { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public InertiaTranslationBehavior Windows.UI.Xaml.Input.IManipulationInertiaStartingRoutedEventArgs.TranslationBehavior { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ManipulationVelocities Windows.UI.Xaml.Input.IManipulationInertiaStartingRoutedEventArgs.Velocities { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

