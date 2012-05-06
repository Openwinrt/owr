namespace Windows.UI.Xaml.Navigation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Interop;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Activatable(typeof(INavigatingCancelEventArgsFactory), 0x6020000), WebHostHidden, Threading(ThreadingModel.Both)]
    public sealed class NavigatingCancelEventArgs : INavigatingCancelEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public NavigatingCancelEventArgs([In] TypeName sourcePageType, [In] Windows.UI.Xaml.Navigation.NavigationMode mode);

        public bool Cancel { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.Navigation.NavigationMode NavigationMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TypeName SourcePageType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Navigation.INavigatingCancelEventArgs.Cancel { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.Navigation.NavigationMode Windows.UI.Xaml.Navigation.INavigatingCancelEventArgs.NavigationMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TypeName Windows.UI.Xaml.Navigation.INavigatingCancelEventArgs.SourcePageType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

