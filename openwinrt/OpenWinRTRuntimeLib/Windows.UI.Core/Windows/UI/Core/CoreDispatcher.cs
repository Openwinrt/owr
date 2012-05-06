namespace Windows.UI.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden]
    public sealed class CoreDispatcher : ICoreDispatcher, ICoreAcceleratorKeys
    {
        public event TypedEventHandler<CoreDispatcher, AcceleratorKeyEventArgs> AcceleratorKeyActivated;

        public event TypedEventHandler<CoreDispatcher, AcceleratorKeyEventArgs> Windows.UI.Core.ICoreAcceleratorKeys.AcceleratorKeyActivated;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Invoke([In] CoreDispatcherPriority priority, [In] InvokedHandler freeThreadedCallback, [In] object sender, [In, Variant] object context);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void InvokeAsync([In] CoreDispatcherPriority priority, [In] InvokedHandler freeThreadedCallback, [In] object sender, [In, Variant] object context);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ProcessEvents([In] CoreProcessEventsOption options);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction RunAsync([In] CoreDispatcherPriority priority, [In] DispatchedHandler agileCallback);

        public bool HasThreadAccess { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Core.ICoreDispatcher.HasThreadAccess { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

