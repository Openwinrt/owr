namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Navigation;

    [Composable(typeof(IPageFactory), CompositionType.Public, 0x6020000), Threading(ThreadingModel.Both), Version(0x6020000), WebHostHidden, Static(typeof(IPageStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class Page : UserControl, IPage, IPageOverrides
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Page();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnNavigatedFrom([In] NavigationEventArgs e);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnNavigatedTo([In] NavigationEventArgs e);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnNavigatingFrom([In] NavigatingCancelEventArgs e);

        public AppBar BottomAppBar { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty BottomAppBarProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Controls.Frame Frame { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty FrameProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Navigation.NavigationCacheMode NavigationCacheMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public AppBar TopAppBar { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty TopAppBarProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public AppBar Windows.UI.Xaml.Controls.IPage.BottomAppBar { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.Controls.Frame Windows.UI.Xaml.Controls.IPage.Frame { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Navigation.NavigationCacheMode Windows.UI.Xaml.Controls.IPage.NavigationCacheMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public AppBar Windows.UI.Xaml.Controls.IPage.TopAppBar { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

