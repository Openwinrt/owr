namespace Windows.UI.Core
{
    using System;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Guid(0x2aa8158f, 0xea82, 0x4d47, 0x81, 0x77, 0xea, 0xf6, 0x48, 0x8f, 0x5b, 0x80), Version(0x6020000), ExclusiveTo(typeof(ContextMenuRequestedEventArgs)), WebHostHidden]
    internal interface IContextMenuRequestedEventArgs : ICoreWindowEventArgs
    {
        bool IsFromTouch { get; }

        Point Position { get; }
    }
}

