namespace Windows.System.Threading
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ThreadPoolWaitHandle)), Windows.Foundation.Metadata.Guid(0x1c4e4566, 0x8400, 0x46d3, 0xa1, 0x15, 0x7d, 12, 13, 0xfc, 0x9f, 0x62), WebHostHidden, Version(0x6020000)]
    internal interface IThreadPoolWaitHandleStatics
    {
        [Overload("AttachToEvent")]
        ThreadPoolWaitHandle AttachToEvent([In] string name, [In] WaitHandler handler);
        [Overload("AttachToEventWithTimeout")]
        ThreadPoolWaitHandle AttachToEvent([In] string name, [In] WaitHandler handler, [In] Windows.Foundation.TimeSpan timeout);
        [Overload("AttachToSemaphore")]
        ThreadPoolWaitHandle AttachToSemaphore([In] string name, [In] WaitHandler handler);
        [Overload("AttachToSemaphoreWithTimeout")]
        ThreadPoolWaitHandle AttachToSemaphore([In] string name, [In] WaitHandler handler, [In] Windows.Foundation.TimeSpan timeout);
    }
}

