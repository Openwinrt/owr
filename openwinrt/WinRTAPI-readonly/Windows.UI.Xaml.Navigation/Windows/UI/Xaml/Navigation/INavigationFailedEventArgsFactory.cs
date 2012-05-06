namespace Windows.UI.Xaml.Navigation
{
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Interop;

    [Version(0x6020000), ExclusiveTo(typeof(NavigationFailedEventArgs)), Windows.Foundation.Metadata.Guid(0x594bda24, 0x6e3, 0x441b, 0xa2, 0xb2, 0xef, 0x9f, 0x25, 0x86, 0x44, 0xcf), WebHostHidden]
    internal interface INavigationFailedEventArgsFactory
    {
        NavigationFailedEventArgs CreateInstanceWithExceptionAndType([In] HResult exception, [In] TypeName sourcePageType);
    }
}

