namespace Windows.Storage.Provider
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class CachedFileUpdaterUI : ICachedFileUpdaterUI
    {
        public event TypedEventHandler<CachedFileUpdaterUI, FileUpdateRequestedEventArgs> FileUpdateRequested;

        public event TypedEventHandler<CachedFileUpdaterUI, object> UIRequested;

        public event TypedEventHandler<CachedFileUpdaterUI, FileUpdateRequestedEventArgs> Windows.Storage.Provider.ICachedFileUpdaterUI.FileUpdateRequested;

        public event TypedEventHandler<CachedFileUpdaterUI, object> Windows.Storage.Provider.ICachedFileUpdaterUI.UIRequested;

        public string Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public CachedFileTarget UpdateTarget { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Storage.Provider.ICachedFileUpdaterUI.Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public CachedFileTarget Windows.Storage.Provider.ICachedFileUpdaterUI.UpdateTarget { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

