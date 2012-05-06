namespace Windows.Storage.Pickers.Provider
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class TargetFileRequestedEventArgs : ITargetFileRequestedEventArgs
    {
        public TargetFileRequest Request { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TargetFileRequest Windows.Storage.Pickers.Provider.ITargetFileRequestedEventArgs.Request { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

