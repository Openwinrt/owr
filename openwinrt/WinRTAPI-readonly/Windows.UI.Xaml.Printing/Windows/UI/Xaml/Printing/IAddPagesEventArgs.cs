namespace Windows.UI.Xaml.Printing
{
    using Windows.Foundation.Metadata;
    using Windows.Graphics.Printing;

    [Guid(0xe2e52be5, 0x56c, 0x4420, 0x97, 0x95, 0xcb, 0x35, 0x26, 0xce, 12, 0x20), ExclusiveTo(typeof(AddPagesEventArgs)), Version(0x6020000), WebHostHidden]
    internal interface IAddPagesEventArgs
    {
        Windows.Graphics.Printing.PrintTaskOptions PrintTaskOptions { get; }
    }
}

