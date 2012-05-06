namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0xe8b2b281, 0xd6a, 0x45cf, 0xb3, 0x33, 0x24, 2, 0xb0, 0x37, 240, 0x99), Version(0x6020000), ExclusiveTo(typeof(Thumb))]
    internal interface IThumb
    {
        event DragCompletedEventHandler DragCompleted;

        event DragDeltaEventHandler DragDelta;

        event DragStartedEventHandler DragStarted;

        void CancelDrag();

        bool IsDragging { get; }
    }
}

