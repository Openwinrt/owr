namespace Windows.UI.Xaml.Printing
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Activatable(0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Threading(ThreadingModel.Both)]
    public sealed class GetPreviewPageEventArgs : IGetPreviewPageEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public GetPreviewPageEventArgs();

        public int PageNumber { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Xaml.Printing.IGetPreviewPageEventArgs.PageNumber { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

