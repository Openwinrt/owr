namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(ImageBrush)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x9fd11377, 0xc12a, 0x4493, 0xbf, 0x7d, 0xf3, 0xa8, 0xad, 0x74, 0xb5, 0x54), Version(0x6020000)]
    internal interface IImageBrush
    {
        event ExceptionRoutedEventHandler ImageFailed;

        event RoutedEventHandler ImageOpened;

        Windows.UI.Xaml.Media.ImageSource ImageSource { get; [param: In] set; }
    }
}

