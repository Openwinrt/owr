namespace Windows.ApplicationModel.Background
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class BackgroundTaskCompletedEventArgs : IBackgroundTaskCompletedEventArgs
    {
        public Guid InstanceId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public HResult Status { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Guid Windows.ApplicationModel.Background.IBackgroundTaskCompletedEventArgs.InstanceId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public HResult Windows.ApplicationModel.Background.IBackgroundTaskCompletedEventArgs.Status { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

