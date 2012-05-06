namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using Windows.Foundation.Metadata;

    [WebHostHidden, ExclusiveTo(typeof(DragStartedEventArgs)), Version(0x6020000), Guid(0x9f915dd0, 0xa124, 0x4366, 0xbd, 0x85, 0x24, 8, 0x21, 0x4a, 0xee, 0xd4)]
    internal interface IDragStartedEventArgs
    {
        double HorizontalOffset { get; }

        double VerticalOffset { get; }
    }
}

