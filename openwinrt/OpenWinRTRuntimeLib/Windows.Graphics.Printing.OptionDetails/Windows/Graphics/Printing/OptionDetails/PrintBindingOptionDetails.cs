namespace Windows.Graphics.Printing.OptionDetails
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class PrintBindingOptionDetails : IPrintOptionDetails, IPrintItemListOptionDetails
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool TrySetValue([In, Variant] object value);

        public string ErrorText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVectorView<object> Items { [return: HasVariant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string OptionId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PrintOptionType OptionType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PrintOptionStates State { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public object Value { [return: HasVariant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<object> Windows.Graphics.Printing.OptionDetails.IPrintItemListOptionDetails.Items { [return: HasVariant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Graphics.Printing.OptionDetails.IPrintOptionDetails.ErrorText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Graphics.Printing.OptionDetails.IPrintOptionDetails.OptionId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PrintOptionType Windows.Graphics.Printing.OptionDetails.IPrintOptionDetails.OptionType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PrintOptionStates Windows.Graphics.Printing.OptionDetails.IPrintOptionDetails.State { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public object Windows.Graphics.Printing.OptionDetails.IPrintOptionDetails.Value { [return: HasVariant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

