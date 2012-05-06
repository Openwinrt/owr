namespace Windows.Storage.Provider
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(CachedFileUpdaterUI)), Windows.Foundation.Metadata.Guid(0x9e6f41e6, 0xbaf2, 0x4a97, 0xb6, 0, 0x93, 0x33, 0xf5, 0xdf, 0x80, 0xfd)]
    internal interface ICachedFileUpdaterUI
    {
        event TypedEventHandler<CachedFileUpdaterUI, FileUpdateRequestedEventArgs> FileUpdateRequested;

        event TypedEventHandler<CachedFileUpdaterUI, object> UIRequested;

        string Title { get; [param: In] set; }

        CachedFileTarget UpdateTarget { get; }
    }
}

