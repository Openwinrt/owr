namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Version(0x6020000), Static(typeof(IAppBarStatics), 0x6020000), WebHostHidden, Activatable(0x6020000)]
    public sealed class AppBar : ContentControl, IAppBar, IAppBarOverrides
    {
        public event Windows.Foundation.EventHandler<object> Closed;

        public event Windows.Foundation.EventHandler<object> Opened;

        public event Windows.Foundation.EventHandler<object> Windows.UI.Xaml.Controls.IAppBar.Closed;

        public event Windows.Foundation.EventHandler<object> Windows.UI.Xaml.Controls.IAppBar.Opened;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public AppBar();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnClosed([In] object e);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnOpened([In] object e);

        public bool IsOpen { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsOpenProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsSticky { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsStickyProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.IAppBar.IsOpen { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.IAppBar.IsSticky { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

