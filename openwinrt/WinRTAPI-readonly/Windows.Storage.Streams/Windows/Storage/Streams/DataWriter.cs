namespace Windows.Storage.Streams
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Threading(ThreadingModel.Both), Activatable(typeof(IDataWriterFactory), 0x6020000), Activatable(0x6020000)]
    public sealed class DataWriter : IDataWriter, IClosable
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DataWriter();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DataWriter([In] IOutputStream outputStream);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Close();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IBuffer DetachBuffer();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IOutputStream DetachStream();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<bool> FlushAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public uint MeasureString([In] string value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DataWriterStoreOperation StoreAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void WriteBoolean([In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("WriteBuffer")]
        public void WriteBuffer([In] IBuffer buffer);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("WriteBufferRange")]
        public void WriteBuffer([In] IBuffer buffer, [In] uint start, [In] uint count);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void WriteByte([In] byte value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void WriteBytes([In] byte[] value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void WriteDateTime([In] Windows.Foundation.DateTime value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void WriteDouble([In] double value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void WriteGuid([In] Guid value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void WriteInt16([In] short value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void WriteInt32([In] int value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void WriteInt64([In] long value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void WriteSingle([In] float value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public uint WriteString([In] string value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void WriteTimeSpan([In] Windows.Foundation.TimeSpan value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void WriteUInt16([In] ushort value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void WriteUInt32([In] uint value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void WriteUInt64([In] ulong value);

        public Windows.Storage.Streams.ByteOrder ByteOrder { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Storage.Streams.UnicodeEncoding UnicodeEncoding { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint UnstoredBufferLength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Storage.Streams.ByteOrder Windows.Storage.Streams.IDataWriter.ByteOrder { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Storage.Streams.UnicodeEncoding Windows.Storage.Streams.IDataWriter.UnicodeEncoding { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.Storage.Streams.IDataWriter.UnstoredBufferLength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

