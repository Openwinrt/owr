namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Composable(typeof(IDispatcherTimerFactory), CompositionType.Public, 0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class DispatcherTimer : IDispatcherTimer
    {
        public event Windows.Foundation.EventHandler<object> Tick;

        public event Windows.Foundation.EventHandler<object> Windows.UI.Xaml.IDispatcherTimer.Tick;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DispatcherTimer();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Start();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Stop();

        public Windows.Foundation.TimeSpan Interval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool IsEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.TimeSpan Windows.UI.Xaml.IDispatcherTimer.Interval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.IDispatcherTimer.IsEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

