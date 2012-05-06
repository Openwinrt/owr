namespace Windows.Storage.Streams
{
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x905a0fe6, 0xbc53, 0x11df, 140, 0x49, 0, 30, 0x4f, 0xc6, 0x86, 0xda)]
    public interface IOutputStream : IClosable
    {
        IAsyncOperation<bool> FlushAsync();
        IAsyncOperationWithProgress<uint, uint> WriteAsync([In] IBuffer buffer);
    }
}

