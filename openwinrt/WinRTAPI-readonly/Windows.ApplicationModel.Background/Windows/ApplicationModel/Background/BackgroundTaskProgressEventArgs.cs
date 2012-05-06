namespace Windows.ApplicationModel.Background
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class BackgroundTaskProgressEventArgs : IBackgroundTaskProgressEventArgs
    {
        public Guid InstanceId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Progress { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Guid Windows.ApplicationModel.Background.IBackgroundTaskProgressEventArgs.InstanceId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.ApplicationModel.Background.IBackgroundTaskProgressEventArgs.Progress { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

