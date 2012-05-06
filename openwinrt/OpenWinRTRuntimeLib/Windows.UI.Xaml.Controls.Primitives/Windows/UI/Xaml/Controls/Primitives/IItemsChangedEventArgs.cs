namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using Windows.Foundation.Metadata;

    [WebHostHidden, ExclusiveTo(typeof(ItemsChangedEventArgs)), Version(0x6020000), Guid(0xe8b45568, 0x7d10, 0x421e, 190, 0x29, 0x81, 0x83, 0x9a, 0x91, 0xde, 0x20)]
    internal interface IItemsChangedEventArgs
    {
        int Action { get; }

        int ItemCount { get; }

        int ItemUICount { get; }

        GeneratorPosition OldPosition { get; }

        GeneratorPosition Position { get; }
    }
}

