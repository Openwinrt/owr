namespace Windows.UI.Xaml.Media.Imaging
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(BitmapImage)), Windows.Foundation.Metadata.Guid(0x31af3271, 0xe3b4, 0x442d, 0xa3, 0x41, 0x4c, 2, 0x26, 0xb2, 0x72, 0x5b), Version(0x6020000), WebHostHidden]
    internal interface IBitmapImage
    {
        event DownloadProgressEventHandler DownloadProgress;

        event ExceptionRoutedEventHandler ImageFailed;

        event RoutedEventHandler ImageOpened;

        BitmapCreateOptions CreateOptions { get; [param: In] set; }

        int DecodePixelHeight { get; [param: In] set; }

        int DecodePixelWidth { get; [param: In] set; }

        Uri UriSource { get; [param: In] set; }
    }
}

