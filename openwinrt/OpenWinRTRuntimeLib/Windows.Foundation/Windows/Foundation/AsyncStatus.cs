namespace Windows.Foundation
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum AsyncStatus
    {
        Started,
        Completed,
        Canceled,
        Error
    }
}

