namespace Windows.UI.Xaml.Navigation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Interop;

    [ExclusiveTo(typeof(NavigationEventArgs)), WebHostHidden, Windows.Foundation.Metadata.Guid(0xb6aa9834, 0x6691, 0x44d1, 0xbd, 0xf7, 0x58, 130, 12, 0x27, 0xb0, 0xd0), Version(0x6020000)]
    internal interface INavigationEventArgs
    {
        object Content { get; }

        Windows.UI.Xaml.Navigation.NavigationMode NavigationMode { get; }

        object Parameter { get; }

        TypeName SourcePageType { get; }

        Windows.Foundation.Uri Uri { get; [param: In] set; }
    }
}

