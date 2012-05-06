namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Markup;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Static(typeof(IUserControlStatics), 0x6020000), WebHostHidden, Threading(ThreadingModel.Both), ContentProperty(Name="Content"), Version(0x6020000), Composable(typeof(IUserControlFactory), CompositionType.Public, 0x6020000)]
    public class UserControl : Control, IUserControl
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public UserControl();

        public UIElement Content { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ContentProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public UIElement Windows.UI.Xaml.Controls.IUserControl.Content { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

