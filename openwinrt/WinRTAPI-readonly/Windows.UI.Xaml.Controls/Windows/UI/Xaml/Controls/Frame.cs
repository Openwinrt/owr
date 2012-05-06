namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Interop;
    using Windows.UI.Xaml.Navigation;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Version(0x6020000), WebHostHidden, Static(typeof(IFrameStatics), 0x6020000), Composable(typeof(IFrameFactory), CompositionType.Public, 0x6020000)]
    public class Frame : ContentControl, IFrame, INavigate
    {
        public event NavigatedEventHandler Navigated;

        public event NavigatingCancelEventHandler Navigating;

        public event NavigationFailedEventHandler NavigationFailed;

        public event NavigationStoppedEventHandler NavigationStopped;

        public event NavigatedEventHandler Windows.UI.Xaml.Controls.IFrame.Navigated;

        public event NavigatingCancelEventHandler Windows.UI.Xaml.Controls.IFrame.Navigating;

        public event NavigationFailedEventHandler Windows.UI.Xaml.Controls.IFrame.NavigationFailed;

        public event NavigationStoppedEventHandler Windows.UI.Xaml.Controls.IFrame.NavigationStopped;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Frame();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string GetNavigationState();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void GoBack();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void GoForward();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool Navigate([In] TypeName sourcePageType);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool Navigate([In] TypeName sourcePageType, [In] object parameter);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetNavigationState([In] string navigationState);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void StopLoading();

        public int CacheSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty CacheSizeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool CanGoBack { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty CanGoBackProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool CanGoForward { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty CanGoForwardProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TypeName CurrentSourcePageType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty CurrentSourcePageTypeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TypeName SourcePageType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty SourcePageTypeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Xaml.Controls.IFrame.CacheSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.IFrame.CanGoBack { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.IFrame.CanGoForward { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TypeName Windows.UI.Xaml.Controls.IFrame.CurrentSourcePageType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TypeName Windows.UI.Xaml.Controls.IFrame.SourcePageType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

