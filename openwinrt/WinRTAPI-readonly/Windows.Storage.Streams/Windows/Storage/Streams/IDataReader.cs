namespace Windows.Storage.Streams
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xe2b50029, 0xb4c1, 0x4314, 0xa4, 0xb8, 0xfb, 0x81, 0x3a, 0x2f, 0x27, 0x5e), Version(0x6020000)]
    public interface IDataReader
    {
        IBuffer DetachBuffer();
        IInputStream DetachStream();
        DataReaderLoadOperation LoadAsync([In] uint count);
        bool ReadBoolean();
        IBuffer ReadBuffer([In] uint length);
        byte ReadByte();
        void ReadBytes([Out] byte[] value);
        Windows.Foundation.DateTime ReadDateTime();
        double ReadDouble();
        Guid ReadGuid();
        short ReadInt16();
        int ReadInt32();
        long ReadInt64();
        float ReadSingle();
        string ReadString([In] uint codeUnitCount);
        Windows.Foundation.TimeSpan ReadTimeSpan();
        ushort ReadUInt16();
        uint ReadUInt32();
        ulong ReadUInt64();

        Windows.Storage.Streams.ByteOrder ByteOrder { get; [param: In] set; }

        Windows.Storage.Streams.InputStreamOptions InputStreamOptions { get; [param: In] set; }

        uint UnconsumedBufferLength { get; }

        Windows.Storage.Streams.UnicodeEncoding UnicodeEncoding { get; [param: In] set; }
    }
}

