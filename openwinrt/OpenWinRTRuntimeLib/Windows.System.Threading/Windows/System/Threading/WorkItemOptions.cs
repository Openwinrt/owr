namespace Windows.System.Threading
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Flags]
    public enum WorkItemOptions : uint
    {
        None = 0,
        TimeSliced = 1
    }
}

