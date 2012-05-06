namespace Windows.Graphics.Printing.OptionDetails
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class PrintCustomItemDetails : IPrintCustomItemDetails
    {
        public string ItemDisplayName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string ItemId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Graphics.Printing.OptionDetails.IPrintCustomItemDetails.ItemDisplayName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Graphics.Printing.OptionDetails.IPrintCustomItemDetails.ItemId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

