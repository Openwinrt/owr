namespace Windows.Graphics.Printing
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class PrintTaskProgressingEventArgs : IPrintTaskProgressingEventArgs
    {
        public uint DocumentPageCount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Graphics.Printing.IPrintTaskProgressingEventArgs.DocumentPageCount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

