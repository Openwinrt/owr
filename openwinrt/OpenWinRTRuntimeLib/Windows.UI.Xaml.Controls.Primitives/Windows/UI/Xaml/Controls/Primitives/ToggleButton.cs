namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Threading(ThreadingModel.Both), WebHostHidden, Version(0x6020000), Static(typeof(IToggleButtonStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Composable(typeof(IToggleButtonFactory), CompositionType.Public, 0x6020000)]
    public class ToggleButton : ButtonBase, IToggleButton, IToggleButtonOverrides
    {
        public event RoutedEventHandler Checked;

        public event RoutedEventHandler Indeterminate;

        public event RoutedEventHandler Unchecked;

        public event RoutedEventHandler Windows.UI.Xaml.Controls.Primitives.IToggleButton.Checked;

        public event RoutedEventHandler Windows.UI.Xaml.Controls.Primitives.IToggleButton.Indeterminate;

        public event RoutedEventHandler Windows.UI.Xaml.Controls.Primitives.IToggleButton.Unchecked;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ToggleButton();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnToggle();

        public IReference<bool> IsChecked { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsCheckedProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsThreeState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsThreeStateProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<bool> Windows.UI.Xaml.Controls.Primitives.IToggleButton.IsChecked { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.Primitives.IToggleButton.IsThreeState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

