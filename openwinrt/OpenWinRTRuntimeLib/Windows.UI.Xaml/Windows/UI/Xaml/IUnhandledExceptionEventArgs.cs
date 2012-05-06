namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x7230269c, 0x54e, 0x4cf3, 0x86, 0xc5, 190, 0x90, 0xeb, 0x68, 0x63, 0xd5), ExclusiveTo(typeof(Windows.UI.Xaml.UnhandledExceptionEventArgs)), WebHostHidden, Version(0x6020000)]
    internal interface IUnhandledExceptionEventArgs
    {
        HResult Exception { get; }

        bool Handled { get; [param: In] set; }

        string Message { get; }
    }
}

