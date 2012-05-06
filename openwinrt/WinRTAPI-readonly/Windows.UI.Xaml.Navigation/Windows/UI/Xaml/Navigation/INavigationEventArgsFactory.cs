namespace Windows.UI.Xaml.Navigation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Interop;

    [ExclusiveTo(typeof(NavigationEventArgs)), Windows.Foundation.Metadata.Guid(0xceff60e4, 0x75f2, 0x4db3, 0x95, 7, 0x12, 20, 40, 0x2f, 0x5d, 0x9e), Version(0x6020000), WebHostHidden]
    internal interface INavigationEventArgsFactory
    {
        NavigationEventArgs CreateInstanceWithContentAndParameterAndTypeAndUriAndNavigationMode([In] object content, [In] object parameter, [In] TypeName sourcePageType, [In] Uri uri, [In] NavigationMode navigationMode);
    }
}

