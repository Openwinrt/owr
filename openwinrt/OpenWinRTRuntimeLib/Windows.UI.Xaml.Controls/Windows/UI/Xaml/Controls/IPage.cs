namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Navigation;

    [Windows.Foundation.Metadata.Guid(0xc4b27075, 0xe641, 0x453e, 130, 0x4d, 1, 0x2f, 0xc7, 0xcf, 0x95, 0xcf), ExclusiveTo(typeof(Page)), Version(0x6020000), WebHostHidden]
    internal interface IPage
    {
        AppBar BottomAppBar { get; [param: In] set; }

        Windows.UI.Xaml.Controls.Frame Frame { get; }

        Windows.UI.Xaml.Navigation.NavigationCacheMode NavigationCacheMode { get; [param: In] set; }

        AppBar TopAppBar { get; [param: In] set; }
    }
}

