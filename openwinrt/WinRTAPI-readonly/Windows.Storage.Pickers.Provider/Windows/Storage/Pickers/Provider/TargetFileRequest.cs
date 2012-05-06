namespace Windows.Storage.Pickers.Provider
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Version(0x6020000)]
    public sealed class TargetFileRequest : ITargetFileRequest
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public TargetFileRequestDeferral GetDeferral();

        public IStorageFile TargetFile { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IStorageFile Windows.Storage.Pickers.Provider.ITargetFileRequest.TargetFile { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

