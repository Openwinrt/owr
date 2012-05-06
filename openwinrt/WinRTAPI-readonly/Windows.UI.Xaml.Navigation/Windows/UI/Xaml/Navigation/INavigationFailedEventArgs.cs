namespace Windows.UI.Xaml.Navigation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Interop;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0x11c1dff7, 0x36c2, 0x4102, 0xb2, 0xef, 2, 0x17, 0xa9, 0x72, 0x89, 0xb3), ExclusiveTo(typeof(NavigationFailedEventArgs)), Version(0x6020000)]
    internal interface INavigationFailedEventArgs
    {
        HResult Exception { get; }

        bool Handled { get; [param: In] set; }

        TypeName SourcePageType { get; }
    }
}

