namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Input;

    [Composable(typeof(IButtonBaseFactory), CompositionType.Protected, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Static(typeof(IButtonBaseStatics), 0x6020000), Threading(ThreadingModel.Both), Version(0x6020000), WebHostHidden]
    public class ButtonBase : ContentControl, IButtonBase
    {
        public event RoutedEventHandler Click;

        public event RoutedEventHandler Windows.UI.Xaml.Controls.Primitives.IButtonBase.Click;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected ButtonBase();

        public Windows.UI.Xaml.Controls.ClickMode ClickMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ClickModeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ICommand Command { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public object CommandParameter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty CommandParameterProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty CommandProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsPointerOver { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty IsPointerOverProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsPressed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty IsPressedProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Controls.ClickMode Windows.UI.Xaml.Controls.Primitives.IButtonBase.ClickMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ICommand Windows.UI.Xaml.Controls.Primitives.IButtonBase.Command { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public object Windows.UI.Xaml.Controls.Primitives.IButtonBase.CommandParameter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.Primitives.IButtonBase.IsPointerOver { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.Primitives.IButtonBase.IsPressed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

