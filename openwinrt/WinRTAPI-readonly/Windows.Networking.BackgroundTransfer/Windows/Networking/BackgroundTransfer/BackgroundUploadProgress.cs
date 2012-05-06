namespace Windows.Networking.BackgroundTransfer
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), Version(0x6020000)]
    public struct BackgroundUploadProgress
    {
        public ulong BytesReceived;
        public ulong BytesSent;
        public ulong TotalBytesToReceive;
        public ulong TotalBytesToSend;
        public BackgroundTransferStatus Status;
        public bool HasResponseChanged;
        public bool HasRestarted;
    }
}

