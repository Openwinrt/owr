namespace Windows.Storage.Streams
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x905a0fe1, 0xbc53, 0x11df, 140, 0x49, 0, 30, 0x4f, 0xc6, 0x86, 0xda)]
    public interface IRandomAccessStream : IClosable, IInputStream, IOutputStream
    {
        IRandomAccessStream CloneStream();
        IInputStream GetInputStreamAt([In] ulong position);
        IOutputStream GetOutputStreamAt([In] ulong position);
        void Seek([In] ulong position);

        bool CanRead { get; }

        bool CanWrite { get; }

        ulong Position { get; }

        ulong Size { get; [param: In] set; }
    }
}

