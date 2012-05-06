namespace Windows.Graphics.Printing
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class PrintTaskCompletedEventArgs : IPrintTaskCompletedEventArgs
    {
        public PrintTaskCompletion Completion { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PrintTaskCompletion Windows.Graphics.Printing.IPrintTaskCompletedEventArgs.Completion { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

