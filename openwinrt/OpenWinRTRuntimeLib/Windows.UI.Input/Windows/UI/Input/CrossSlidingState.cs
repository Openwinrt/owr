namespace Windows.UI.Input
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum CrossSlidingState
    {
        Started,
        Dragging,
        Selecting,
        SelectSpeedBumping,
        SpeedBumping,
        Rearranging,
        Completed
    }
}

