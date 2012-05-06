namespace Windows.UI.Core
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(VisibilityChangedEventArgs)), Version(0x6020000), Guid(0xbf9918ea, 0xd801, 0x4564, 0xa4, 0x95, 0xb1, 0xe8, 0x4f, 0x8a, 0xd0, 0x85), WebHostHidden]
    internal interface IVisibilityChangedEventArgs : ICoreWindowEventArgs
    {
        bool Visible { get; }
    }
}

