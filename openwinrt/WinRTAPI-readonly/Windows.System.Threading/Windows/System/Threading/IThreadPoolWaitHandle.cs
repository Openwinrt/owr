namespace Windows.System.Threading
{
    using System;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), Guid(0x14285e06, 0x63a7, 0x4713, 0xb6, 0xd9, 0x62, 0xf6, 0x4b, 0x56, 0xfb, 0x8b)]
    public interface IThreadPoolWaitHandle
    {
        void Cancel();
        void Submit();
    }
}

