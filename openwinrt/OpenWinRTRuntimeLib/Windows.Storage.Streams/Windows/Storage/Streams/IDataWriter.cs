namespace Windows.Storage.Streams
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x64b89265, 0xd341, 0x4922, 0xb3, 0x8a, 0xdd, 0x4a, 0xf8, 0x80, 140, 0x4e)]
    public interface IDataWriter
    {
        IBuffer DetachBuffer();
        IOutputStream DetachStream();
        IAsyncOperation<bool> FlushAsync();
        uint MeasureString([In] string value);
        DataWriterStoreOperation StoreAsync();
        void WriteBoolean([In] bool value);
        [Overload("WriteBuffer")]
        void WriteBuffer([In] IBuffer buffer);
        [Overload("WriteBufferRange")]
        void WriteBuffer([In] IBuffer buffer, [In] uint start, [In] uint count);
        void WriteByte([In] byte value);
        void WriteBytes([In] byte[] value);
        void WriteDateTime([In] Windows.Foundation.DateTime value);
        void WriteDouble([In] double value);
        void WriteGuid([In] Guid value);
        void WriteInt16([In] short value);
        void WriteInt32([In] int value);
        void WriteInt64([In] long value);
        void WriteSingle([In] float value);
        uint WriteString([In] string value);
        void WriteTimeSpan([In] Windows.Foundation.TimeSpan value);
        void WriteUInt16([In] ushort value);
        void WriteUInt32([In] uint value);
        void WriteUInt64([In] ulong value);

        Windows.Storage.Streams.ByteOrder ByteOrder { get; [param: In] set; }

        Windows.Storage.Streams.UnicodeEncoding UnicodeEncoding { get; [param: In] set; }

        uint UnstoredBufferLength { get; }
    }
}

