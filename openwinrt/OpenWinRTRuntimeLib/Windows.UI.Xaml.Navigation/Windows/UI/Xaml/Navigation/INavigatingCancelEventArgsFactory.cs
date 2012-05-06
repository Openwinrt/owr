namespace Windows.UI.Xaml.Navigation
{
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Interop;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0xaece6857, 0xf3a, 0x47e8, 0xad, 0xe1, 0x91, 0xf1, 0x9a, 0xba, 0x1c, 0), ExclusiveTo(typeof(NavigatingCancelEventArgs))]
    internal interface INavigatingCancelEventArgsFactory
    {
        NavigatingCancelEventArgs CreateInstanceWithTypeAndNavigationMode([In] TypeName sourcePageType, [In] NavigationMode mode);
    }
}

