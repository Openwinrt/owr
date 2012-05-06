namespace Windows.System.Threading
{
    using System;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000)]
    public enum WorkItemPriority
    {
        High = 1,
        Low = -1,
        Normal = 0
    }
}

