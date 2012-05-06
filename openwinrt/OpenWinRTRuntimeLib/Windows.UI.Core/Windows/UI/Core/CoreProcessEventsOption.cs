namespace Windows.UI.Core
{
    using System;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000)]
    public enum CoreProcessEventsOption
    {
        ProcessOneAndAllPending,
        ProcessOneIfPresent,
        ProcessUntilQuit,
        ProcessAllIfPresent
    }
}

