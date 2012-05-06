namespace Windows.Graphics.Printing.OptionDetails
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(PrintCustomItemListOptionDetails)), Windows.Foundation.Metadata.Guid(0xa5fafd88, 0x58f2, 0x4ebd, 0xb9, 15, 0x51, 0xe4, 0xf2, 0x94, 0x4c, 0x5d), Version(0x6020000)]
    internal interface IPrintCustomItemListOptionDetails : IPrintItemListOptionDetails, IPrintOptionDetails, IPrintCustomOptionDetails
    {
        void AddItem([In] string itemId, [In] string displayName);
    }
}

