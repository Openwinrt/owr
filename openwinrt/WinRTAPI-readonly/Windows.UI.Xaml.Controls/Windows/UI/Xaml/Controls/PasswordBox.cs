namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Version(0x6020000), Activatable(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Static(typeof(IPasswordBoxStatics), 0x6020000)]
    public sealed class PasswordBox : Control, IPasswordBox
    {
        public event ContextMenuOpeningEventHandler ContextMenuOpening;

        public event RoutedEventHandler PasswordChanged;

        public event ContextMenuOpeningEventHandler Windows.UI.Xaml.Controls.IPasswordBox.ContextMenuOpening;

        public event RoutedEventHandler Windows.UI.Xaml.Controls.IPasswordBox.PasswordChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PasswordBox();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SelectAll();

        public bool IsPasswordRevealButtonEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsPasswordRevealButtonEnabledProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int MaxLength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty MaxLengthProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Password { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string PasswordChar { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty PasswordCharProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty PasswordProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.IPasswordBox.IsPasswordRevealButtonEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public int Windows.UI.Xaml.Controls.IPasswordBox.MaxLength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Xaml.Controls.IPasswordBox.Password { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Xaml.Controls.IPasswordBox.PasswordChar { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

