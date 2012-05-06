namespace Windows.Storage.Streams
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Version(0x6020000), Static(typeof(IDataReaderStatics), 0x6020000), Activatable(typeof(IDataReaderFactory), 0x6020000)]
    public sealed class DataReader : IDataReader, IClosable
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DataReader([In] IInputStream inputStream);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Close();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IBuffer DetachBuffer();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IInputStream DetachStream();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static DataReader FromBuffer([In] IBuffer buffer);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DataReaderLoadOperation LoadAsync([In] uint count);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool ReadBoolean();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IBuffer ReadBuffer([In] uint length);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public byte ReadByte();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ReadBytes([Out] byte[] value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Windows.Foundation.DateTime ReadDateTime();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public double ReadDouble();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Guid ReadGuid();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public short ReadInt16();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public int ReadInt32();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public long ReadInt64();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public float ReadSingle();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string ReadString([In] uint codeUnitCount);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Windows.Foundation.TimeSpan ReadTimeSpan();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ushort ReadUInt16();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public uint ReadUInt32();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ulong ReadUInt64();

        public Windows.Storage.Streams.ByteOrder ByteOrder { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Storage.Streams.InputStreamOptions InputStreamOptions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint UnconsumedBufferLength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Storage.Streams.UnicodeEncoding UnicodeEncoding { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Storage.Streams.ByteOrder Windows.Storage.Streams.IDataReader.ByteOrder { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Storage.Streams.InputStreamOptions Windows.Storage.Streams.IDataReader.InputStreamOptions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.Storage.Streams.IDataReader.UnconsumedBufferLength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Storage.Streams.UnicodeEncoding Windows.Storage.Streams.IDataReader.UnicodeEncoding { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

