namespace Windows.Networking.BackgroundTransfer
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), Version(0x6020000)]
    public struct BackgroundDownloadProgress
    {
        public ulong BytesReceived;
        public ulong TotalBytesToReceive;
        public BackgroundTransferStatus Status;
        public bool HasResponseChanged;
        public bool HasRestarted;
    }
}

