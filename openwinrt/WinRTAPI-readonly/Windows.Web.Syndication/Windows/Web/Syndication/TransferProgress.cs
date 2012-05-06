namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), Version(0x6020000)]
    public struct TransferProgress
    {
        public uint bytesSent;
        public uint totalBytesToSend;
        public uint bytesRetrieved;
        public uint totalBytesToRetrieve;
    }
}

