namespace Windows.UI.Xaml.Media.Imaging
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x7311e0d4, 0xfe94, 0x4e70, 0x9b, 0x90, 0xcd, 0xd4, 0x7a, 0xc2, 0x3a, 0xfb), WebHostHidden, ExclusiveTo(typeof(DownloadProgressEventArgs))]
    internal interface IDownloadProgressEventArgs
    {
        int Progress { get; [param: In] set; }
    }
}

