namespace Windows.ApplicationModel.DataTransfer.ShareTarget
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Version(0x6020000), Activatable(0x6020000)]
    public sealed class QuickLink : IQuickLink
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public QuickLink();

        public string Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<string> SupportedDataFormats { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<string> SupportedFileTypes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public RandomAccessStreamReference Thumbnail { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.ApplicationModel.DataTransfer.ShareTarget.IQuickLink.Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<string> Windows.ApplicationModel.DataTransfer.ShareTarget.IQuickLink.SupportedDataFormats { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<string> Windows.ApplicationModel.DataTransfer.ShareTarget.IQuickLink.SupportedFileTypes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public RandomAccessStreamReference Windows.ApplicationModel.DataTransfer.ShareTarget.IQuickLink.Thumbnail { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.ApplicationModel.DataTransfer.ShareTarget.IQuickLink.Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

