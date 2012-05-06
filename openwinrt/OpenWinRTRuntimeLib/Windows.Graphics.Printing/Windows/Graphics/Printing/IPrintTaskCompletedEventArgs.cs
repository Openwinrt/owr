namespace Windows.Graphics.Printing
{
    using Windows.Foundation.Metadata;

    [Guid(0x5bcd34af, 0x24e9, 0x4c10, 0x8d, 7, 20, 0xc3, 70, 0xba, 0x3f, 0xce), ExclusiveTo(typeof(PrintTaskCompletedEventArgs)), Version(0x6020000)]
    internal interface IPrintTaskCompletedEventArgs
    {
        PrintTaskCompletion Completion { get; }
    }
}

