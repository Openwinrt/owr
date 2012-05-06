namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(DragCompletedEventArgs)), Guid(0xb04f29a1, 0xbd16, 0x48f6, 0xa5, 0x11, 0x9c, 0x27, 0x63, 100, 0x13, 0x31), WebHostHidden, Version(0x6020000)]
    internal interface IDragCompletedEventArgs
    {
        bool Canceled { get; }

        double HorizontalChange { get; }

        double VerticalChange { get; }
    }
}

