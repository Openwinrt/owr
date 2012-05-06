namespace Windows.System.Threading
{
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(ThreadPool)), Windows.Foundation.Metadata.Guid(0xb6bf67dd, 0x84bd, 0x44f8, 0xac, 0x1c, 0x93, 0xeb, 0xcb, 0x9d, 0xba, 0x91)]
    internal interface IThreadPoolStatics
    {
        [Overload("RunAsync")]
        IAsyncAction RunAsync([In] WorkItemHandler handler);
        [Overload("RunWithPriorityAsync")]
        IAsyncAction RunAsync([In] WorkItemHandler handler, [In] WorkItemPriority priority);
        [Overload("RunWithPriorityAndOptionsAsync")]
        IAsyncAction RunAsync([In] WorkItemHandler handler, [In] WorkItemPriority priority, [In] WorkItemOptions options);
    }
}

