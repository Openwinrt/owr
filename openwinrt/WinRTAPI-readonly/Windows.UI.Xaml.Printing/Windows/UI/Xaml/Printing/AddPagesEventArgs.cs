namespace Windows.UI.Xaml.Printing
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.Graphics.Printing;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Activatable(0x6020000), Version(0x6020000), Threading(ThreadingModel.Both), WebHostHidden]
    public sealed class AddPagesEventArgs : IAddPagesEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public AddPagesEventArgs();

        public Windows.Graphics.Printing.PrintTaskOptions PrintTaskOptions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Graphics.Printing.PrintTaskOptions Windows.UI.Xaml.Printing.IAddPagesEventArgs.PrintTaskOptions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

