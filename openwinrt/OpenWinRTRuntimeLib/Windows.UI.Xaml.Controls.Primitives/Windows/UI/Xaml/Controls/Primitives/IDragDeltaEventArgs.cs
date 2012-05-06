namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(DragDeltaEventArgs)), Guid(0x2c2dd73c, 0x2806, 0x49fc, 170, 0xe9, 0x6d, 0x79, 0x2b, 0x57, 0x2b, 0x6a), Version(0x6020000), WebHostHidden]
    internal interface IDragDeltaEventArgs
    {
        double HorizontalChange { get; }

        double VerticalChange { get; }
    }
}

