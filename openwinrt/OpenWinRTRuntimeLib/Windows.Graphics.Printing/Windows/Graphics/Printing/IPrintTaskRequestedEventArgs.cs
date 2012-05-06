namespace Windows.Graphics.Printing
{
    using Windows.Foundation.Metadata;

    [Guid(0xd0aff924, 0xa31b, 0x454c, 0xa7, 0xb6, 0x5d, 12, 0xc5, 0x22, 0xfc, 0x16), ExclusiveTo(typeof(PrintTaskRequestedEventArgs)), Version(0x6020000)]
    internal interface IPrintTaskRequestedEventArgs
    {
        PrintTaskRequest Request { get; }
    }
}

