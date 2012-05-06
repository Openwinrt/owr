namespace Windows.UI.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x9a0129d5, 0x63, 0x4de3, 0xb3, 250, 0xd1, 0x2f, 0xce, 0xc2, 0x40, 0xa5), ExclusiveTo(typeof(CoreDispatcher)), WebHostHidden]
    internal interface ICoreDispatcher : ICoreAcceleratorKeys
    {
        void Invoke([In] CoreDispatcherPriority priority, [In] InvokedHandler freeThreadedCallback, [In] object sender, [In, Variant] object context);
        void InvokeAsync([In] CoreDispatcherPriority priority, [In] InvokedHandler freeThreadedCallback, [In] object sender, [In, Variant] object context);
        void ProcessEvents([In] CoreProcessEventsOption options);
        IAsyncAction RunAsync([In] CoreDispatcherPriority priority, [In] DispatchedHandler agileCallback);

        bool HasThreadAccess { get; }
    }
}

