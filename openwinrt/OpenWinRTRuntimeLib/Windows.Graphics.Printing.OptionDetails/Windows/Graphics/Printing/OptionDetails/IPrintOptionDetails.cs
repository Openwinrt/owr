namespace Windows.Graphics.Printing.OptionDetails
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x390686cf, 0xd682, 0x495f, 0xad, 0xfe, 0xd7, 0x33, 0x3f, 0x5c, 0x18, 8), Version(0x6020000)]
    public interface IPrintOptionDetails
    {
        bool TrySetValue([In, Variant] object value);

        string ErrorText { get; [param: In] set; }

        string OptionId { get; }

        PrintOptionType OptionType { get; }

        PrintOptionStates State { get; [param: In] set; }

        object Value { [return: HasVariant] get; }
    }
}

