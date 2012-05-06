namespace Windows.UI.Xaml.Navigation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Interop;

    [Version(0x6020000), ExclusiveTo(typeof(NavigatingCancelEventArgs)), Windows.Foundation.Metadata.Guid(0xfd1d67ae, 0xeafb, 0x4079, 190, 0x80, 0x6d, 0xc9, 0x2a, 3, 0xae, 0xdf), WebHostHidden]
    internal interface INavigatingCancelEventArgs
    {
        bool Cancel { get; [param: In] set; }

        Windows.UI.Xaml.Navigation.NavigationMode NavigationMode { get; }

        TypeName SourcePageType { get; }
    }
}

