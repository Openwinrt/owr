namespace Windows.UI.Core
{
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Guid(0x5a200ec7, 0x426, 0x47dc, 0xb8, 0x6c, 0x6f, 0x47, 0x59, 0x15, 0xe4, 0x51), ExclusiveTo(typeof(WindowSizeChangedEventArgs)), Version(0x6020000)]
    internal interface IWindowSizeChangedEventArgs : ICoreWindowEventArgs
    {
        Windows.Foundation.Size Size { get; }
    }
}

