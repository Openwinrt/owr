namespace Windows.Graphics.Printing
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class PrintTaskSourceRequestedDeferral : IPrintTaskSourceRequestedDeferral
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Complete();
    }
}

