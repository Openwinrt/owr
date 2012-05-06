namespace Windows.System.Threading
{
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ThreadPoolTimer)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x1a8a9d02, 0xe482, 0x461b, 0xb8, 0xc7, 0x8e, 250, 0xd1, 0xcc, 0xe5, 0x90), WebHostHidden]
    internal interface IThreadPoolTimerStatics
    {
        ThreadPoolTimer CreatePeriodicTimer([In] TimerElapsedHandler handler, [In] TimeSpan period);
        ThreadPoolTimer CreateTimer([In] TimerElapsedHandler handler, [In] TimeSpan delay);
    }
}

