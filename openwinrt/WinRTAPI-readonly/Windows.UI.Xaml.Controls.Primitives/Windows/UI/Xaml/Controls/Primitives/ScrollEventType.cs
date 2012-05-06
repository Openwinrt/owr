namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000)]
    public enum ScrollEventType
    {
        SmallDecrement,
        SmallIncrement,
        LargeDecrement,
        LargeIncrement,
        ThumbPosition,
        ThumbTrack,
        First,
        Last,
        EndScroll
    }
}

