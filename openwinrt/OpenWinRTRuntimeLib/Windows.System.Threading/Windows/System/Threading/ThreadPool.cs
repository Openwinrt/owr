namespace Windows.System.Threading
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Threading(ThreadingModel.MTA), Static(typeof(IThreadPoolStatics), 0x6020000), Version(0x6020000)]
    public static class ThreadPool
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RunAsync")]
        public static IAsyncAction RunAsync([In] WorkItemHandler handler);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RunWithPriorityAsync")]
        public static IAsyncAction RunAsync([In] WorkItemHandler handler, [In] WorkItemPriority priority);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RunWithPriorityAndOptionsAsync")]
        public static IAsyncAction RunAsync([In] WorkItemHandler handler, [In] WorkItemPriority priority, [In] WorkItemOptions options);
    }
}

