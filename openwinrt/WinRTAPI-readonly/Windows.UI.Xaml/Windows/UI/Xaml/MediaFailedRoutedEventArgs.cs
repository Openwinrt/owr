namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class MediaFailedRoutedEventArgs : ExceptionRoutedEventArgs, IMediaFailedRoutedEventArgs
    {
        public string ErrorTrace { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.UI.Xaml.IMediaFailedRoutedEventArgs.ErrorTrace { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

