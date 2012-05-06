namespace Windows.UI.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden]
    public sealed class InvokedHandlerArgs : IInvokedHandlerArgs
    {
        public object Context { [return: Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Windows.UI.Core.IInvokedHandlerArgs.Context { [return: Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

