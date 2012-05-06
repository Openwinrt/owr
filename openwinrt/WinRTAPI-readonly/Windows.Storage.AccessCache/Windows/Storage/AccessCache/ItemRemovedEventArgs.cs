namespace Windows.Storage.AccessCache
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class ItemRemovedEventArgs : IItemRemovedEventArgs
    {
        public AccessListEntry RemovedEntry { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public AccessListEntry Windows.Storage.AccessCache.IItemRemovedEventArgs.RemovedEntry { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

