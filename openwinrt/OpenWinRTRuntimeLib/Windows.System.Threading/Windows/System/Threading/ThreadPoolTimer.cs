namespace Windows.System.Threading
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Static(typeof(IThreadPoolTimerStatics), 0x6020000), WebHostHidden, Threading(ThreadingModel.MTA)]
    public sealed class ThreadPoolTimer : IThreadPoolTimer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Cancel();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static ThreadPoolTimer CreatePeriodicTimer([In] TimerElapsedHandler handler, [In] Windows.Foundation.TimeSpan period);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static ThreadPoolTimer CreateTimer([In] TimerElapsedHandler handler, [In] Windows.Foundation.TimeSpan delay);

        public Windows.Foundation.TimeSpan Delay { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.TimeSpan Period { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.TimeSpan Windows.System.Threading.IThreadPoolTimer.Delay { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.TimeSpan Windows.System.Threading.IThreadPoolTimer.Period { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

