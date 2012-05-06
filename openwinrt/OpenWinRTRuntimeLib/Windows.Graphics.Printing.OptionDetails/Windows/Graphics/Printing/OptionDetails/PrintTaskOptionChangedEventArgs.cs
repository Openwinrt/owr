namespace Windows.Graphics.Printing.OptionDetails
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class PrintTaskOptionChangedEventArgs : IPrintTaskOptionChangedEventArgs
    {
        public object OptionId { [return: HasVariant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Windows.Graphics.Printing.OptionDetails.IPrintTaskOptionChangedEventArgs.OptionId { [return: HasVariant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

