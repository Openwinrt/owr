namespace Windows.UI.Xaml.Printing
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.Graphics.Printing;

    [Version(0x6020000), Activatable(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), WebHostHidden]
    public sealed class PaginateEventArgs : IPaginateEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PaginateEventArgs();

        public int CurrentPreviewPageNumber { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Graphics.Printing.PrintTaskOptions PrintTaskOptions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Xaml.Printing.IPaginateEventArgs.CurrentPreviewPageNumber { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Graphics.Printing.PrintTaskOptions Windows.UI.Xaml.Printing.IPaginateEventArgs.PrintTaskOptions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

