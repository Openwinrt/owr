namespace Windows.UI.Xaml.Media.Imaging
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Version(0x6020000), Threading(ThreadingModel.Both)]
    public sealed class DownloadProgressEventArgs : IDownloadProgressEventArgs
    {
        public int Progress { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public int Windows.UI.Xaml.Media.Imaging.IDownloadProgressEventArgs.Progress { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

