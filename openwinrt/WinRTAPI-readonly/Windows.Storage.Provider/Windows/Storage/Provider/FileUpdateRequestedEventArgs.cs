namespace Windows.Storage.Provider
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class FileUpdateRequestedEventArgs : IFileUpdateRequestedEventArgs
    {
        public FileUpdateRequest Request { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public FileUpdateRequest Windows.Storage.Provider.IFileUpdateRequestedEventArgs.Request { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

