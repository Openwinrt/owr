namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Navigation;

    [ExclusiveTo(typeof(Page)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x230b9cb8, 0x3419, 0x4306, 170, 190, 0x4a, 0x8e, 0x68, 13, 0x36, 0x27), Version(0x6020000)]
    internal interface IPageOverrides
    {
        void OnNavigatedFrom([In] NavigationEventArgs e);
        void OnNavigatedTo([In] NavigationEventArgs e);
        void OnNavigatingFrom([In] NavigatingCancelEventArgs e);
    }
}

