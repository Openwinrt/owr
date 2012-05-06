namespace Windows.Storage.Pickers.Provider
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class FileRemovedEventArgs : IFileRemovedEventArgs
    {
        public string Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Storage.Pickers.Provider.IFileRemovedEventArgs.Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

