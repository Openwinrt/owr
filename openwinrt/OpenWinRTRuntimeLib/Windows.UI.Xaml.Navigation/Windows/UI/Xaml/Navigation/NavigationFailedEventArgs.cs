namespace Windows.UI.Xaml.Navigation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Interop;

    [Version(0x6020000), Activatable(typeof(INavigationFailedEventArgsFactory), 0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden]
    public sealed class NavigationFailedEventArgs : INavigationFailedEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public NavigationFailedEventArgs([In] HResult exception, [In] TypeName sourcePageType);

        public HResult Exception { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public TypeName SourcePageType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public HResult Windows.UI.Xaml.Navigation.INavigationFailedEventArgs.Exception { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Navigation.INavigationFailedEventArgs.Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public TypeName Windows.UI.Xaml.Navigation.INavigationFailedEventArgs.SourcePageType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

