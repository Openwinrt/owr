namespace Windows.Foundation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x5a648006, 0x843a, 0x4da9, 0x86, 0x5b, 0x9d, 0x26, 0xe5, 0xdf, 0xad, 0x7b), Version(0x6020000)]
    public interface IAsyncAction : IAsyncInfo
    {
        void GetResults();

        AsyncActionCompletedHandler Completed { get; [param: In] set; }
    }
}

