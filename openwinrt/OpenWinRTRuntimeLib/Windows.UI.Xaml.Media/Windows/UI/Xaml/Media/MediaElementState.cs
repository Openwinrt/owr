namespace Windows.UI.Xaml.Media
{
    using System;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000)]
    public enum MediaElementState
    {
        Closed,
        Opening,
        Buffering,
        Playing,
        Paused,
        Stopped
    }
}

