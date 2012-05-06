namespace Windows.Graphics.Printing
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class PrintTaskRequestedEventArgs : IPrintTaskRequestedEventArgs
    {
        public PrintTaskRequest Request { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PrintTaskRequest Windows.Graphics.Printing.IPrintTaskRequestedEventArgs.Request { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

