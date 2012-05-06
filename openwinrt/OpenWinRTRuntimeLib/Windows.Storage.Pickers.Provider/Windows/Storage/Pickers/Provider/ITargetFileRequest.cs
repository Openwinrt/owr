namespace Windows.Storage.Pickers.Provider
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Windows.Foundation.Metadata.Guid(0x42bd3355, 0x7f88, 0x478b, 0x8e, 0x81, 0x69, 11, 0x20, 0x34, 6, 120), Version(0x6020000), ExclusiveTo(typeof(TargetFileRequest))]
    internal interface ITargetFileRequest
    {
        TargetFileRequestDeferral GetDeferral();

        IStorageFile TargetFile { get; [param: In] set; }
    }
}

