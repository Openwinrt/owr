namespace Windows.Graphics.Printing.OptionDetails
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(PrintCustomItemDetails)), Windows.Foundation.Metadata.Guid(0x5704b637, 0x5c3a, 0x449a, 170, 0x36, 0xb3, 0x29, 0x1b, 0x11, 0x92, 0xfd), Version(0x6020000)]
    internal interface IPrintCustomItemDetails
    {
        string ItemDisplayName { get; [param: In] set; }

        string ItemId { get; }
    }
}

