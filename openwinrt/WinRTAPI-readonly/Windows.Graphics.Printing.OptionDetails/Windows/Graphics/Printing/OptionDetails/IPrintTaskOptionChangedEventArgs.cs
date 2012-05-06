namespace Windows.Graphics.Printing.OptionDetails
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x65197d05, 0xa5ee, 0x4307, 0x94, 7, 0x9a, 0xca, 0xd1, 0x47, 0x67, 0x9c), ExclusiveTo(typeof(PrintTaskOptionChangedEventArgs))]
    internal interface IPrintTaskOptionChangedEventArgs
    {
        object OptionId { [return: HasVariant] get; }
    }
}

