namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(RoutedEventArgs)), Windows.Foundation.Metadata.Guid(0xb61c4d87, 0x70e5, 0x412e, 0xb5, 0x20, 0x1a, 0x41, 0xee, 0x76, 0xbb, 0xf4)]
    internal interface IRoutedEventArgsFactory
    {
        RoutedEventArgs CreateInstance([In] object outer, out object inner);
    }
}

