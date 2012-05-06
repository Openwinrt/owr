namespace Windows.System.Threading
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.MTA), Version(0x6020000), Static(typeof(IThreadPoolWaitHandleStatics), 0x6020000), WebHostHidden]
    public sealed class ThreadPoolWaitHandle : IThreadPoolWaitHandle
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("AttachToEvent")]
        public static ThreadPoolWaitHandle AttachToEvent([In] string name, [In] WaitHandler handler);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("AttachToEventWithTimeout")]
        public static ThreadPoolWaitHandle AttachToEvent([In] string name, [In] WaitHandler handler, [In] Windows.Foundation.TimeSpan timeout);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("AttachToSemaphore")]
        public static ThreadPoolWaitHandle AttachToSemaphore([In] string name, [In] WaitHandler handler);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("AttachToSemaphoreWithTimeout")]
        public static ThreadPoolWaitHandle AttachToSemaphore([In] string name, [In] WaitHandler handler, [In] Windows.Foundation.TimeSpan timeout);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Cancel();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Submit();
    }
}

