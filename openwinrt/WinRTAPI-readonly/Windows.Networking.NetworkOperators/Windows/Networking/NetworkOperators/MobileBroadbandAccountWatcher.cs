namespace Windows.Networking.NetworkOperators
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000), Activatable(0x6020000)]
    public sealed class MobileBroadbandAccountWatcher : IMobileBroadbandAccountWatcher
    {
        public event TypedEventHandler<MobileBroadbandAccountWatcher, MobileBroadbandAccountEventArgs> AccountAdded;

        public event TypedEventHandler<MobileBroadbandAccountWatcher, MobileBroadbandAccountEventArgs> AccountRemoved;

        public event TypedEventHandler<MobileBroadbandAccountWatcher, MobileBroadbandAccountUpdatedEventArgs> AccountUpdated;

        public event TypedEventHandler<MobileBroadbandAccountWatcher, object> EnumerationCompleted;

        public event TypedEventHandler<MobileBroadbandAccountWatcher, object> Stopped;

        public event TypedEventHandler<MobileBroadbandAccountWatcher, MobileBroadbandAccountEventArgs> Windows.Networking.NetworkOperators.IMobileBroadbandAccountWatcher.AccountAdded;

        public event TypedEventHandler<MobileBroadbandAccountWatcher, MobileBroadbandAccountEventArgs> Windows.Networking.NetworkOperators.IMobileBroadbandAccountWatcher.AccountRemoved;

        public event TypedEventHandler<MobileBroadbandAccountWatcher, MobileBroadbandAccountUpdatedEventArgs> Windows.Networking.NetworkOperators.IMobileBroadbandAccountWatcher.AccountUpdated;

        public event TypedEventHandler<MobileBroadbandAccountWatcher, object> Windows.Networking.NetworkOperators.IMobileBroadbandAccountWatcher.EnumerationCompleted;

        public event TypedEventHandler<MobileBroadbandAccountWatcher, object> Windows.Networking.NetworkOperators.IMobileBroadbandAccountWatcher.Stopped;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public MobileBroadbandAccountWatcher();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Start();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Stop();

        public MobileBroadbandAccountWatcherStatus Status { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MobileBroadbandAccountWatcherStatus Windows.Networking.NetworkOperators.IMobileBroadbandAccountWatcher.Status { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

