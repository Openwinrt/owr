namespace Windows.UI.Xaml
{
    using System;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Guid(0x5c985ac6, 0xd802, 0x4b38, 0xa2, 0x23, 0xbf, 7, 12, 0x43, 0xfe, 0xdf), Version(0x6020000), ExclusiveTo(typeof(RoutedEventArgs))]
    internal interface IRoutedEventArgs
    {
        object OriginalSource { get; }
    }
}

