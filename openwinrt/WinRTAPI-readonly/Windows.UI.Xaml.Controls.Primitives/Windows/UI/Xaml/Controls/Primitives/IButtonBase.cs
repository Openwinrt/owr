namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Input;

    [Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(ButtonBase)), Windows.Foundation.Metadata.Guid(0xfa002c1a, 0x494e, 0x46cf, 0x91, 0xd4, 0xe1, 0x4a, 0x8d, 0x79, 0x86, 0x74)]
    internal interface IButtonBase
    {
        event RoutedEventHandler Click;

        Windows.UI.Xaml.Controls.ClickMode ClickMode { get; [param: In] set; }

        ICommand Command { get; [param: In] set; }

        object CommandParameter { get; [param: In] set; }

        bool IsPointerOver { get; }

        bool IsPressed { get; }
    }
}

