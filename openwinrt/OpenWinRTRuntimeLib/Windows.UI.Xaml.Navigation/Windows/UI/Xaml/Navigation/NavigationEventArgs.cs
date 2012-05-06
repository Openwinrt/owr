namespace Windows.UI.Xaml.Navigation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Interop;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Activatable(typeof(INavigationEventArgsFactory), 0x6020000), WebHostHidden, Threading(ThreadingModel.Both)]
    public sealed class NavigationEventArgs : INavigationEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public NavigationEventArgs([In] object content, [In] object parameter, [In] TypeName sourcePageType, [In] Windows.Foundation.Uri uri, [In] Windows.UI.Xaml.Navigation.NavigationMode navigationMode);

        public object Content { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Navigation.NavigationMode NavigationMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Parameter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TypeName SourcePageType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.Uri Uri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public object Windows.UI.Xaml.Navigation.INavigationEventArgs.Content { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Navigation.NavigationMode Windows.UI.Xaml.Navigation.INavigationEventArgs.NavigationMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Windows.UI.Xaml.Navigation.INavigationEventArgs.Parameter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TypeName Windows.UI.Xaml.Navigation.INavigationEventArgs.SourcePageType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.Uri Windows.UI.Xaml.Navigation.INavigationEventArgs.Uri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

