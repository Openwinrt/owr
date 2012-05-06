namespace Windows.Storage
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [ExclusiveTo(typeof(FileIO)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x887411eb, 0x7f54, 0x4732, 0xa5, 240, 0x5e, 0x43, 0xe3, 0xb8, 0xc2, 0xf5)]
    internal interface IFileIOStatics
    {
        [Overload("AppendLinesAsync")]
        IAsyncAction AppendLinesAsync([In] IStorageFile file, [In] IIterable<string> lines);
        [Overload("AppendLinesWithEncodingAsync")]
        IAsyncAction AppendLinesAsync([In] IStorageFile file, [In] IIterable<string> lines, [In] UnicodeEncoding encoding);
        [Overload("AppendTextAsync")]
        IAsyncAction AppendTextAsync([In] IStorageFile file, [In] string contents);
        [Overload("AppendTextWithEncodingAsync")]
        IAsyncAction AppendTextAsync([In] IStorageFile file, [In] string contents, [In] UnicodeEncoding encoding);
        IAsyncOperation<IBuffer> ReadBufferAsync([In] IStorageFile file);
        [Overload("ReadLinesAsync")]
        IAsyncOperation<IVector<string>> ReadLinesAsync([In] IStorageFile file);
        [Overload("ReadLinesWithEncodingAsync")]
        IAsyncOperation<IVector<string>> ReadLinesAsync([In] IStorageFile file, [In] UnicodeEncoding encoding);
        [Overload("ReadTextAsync")]
        IAsyncOperation<string> ReadTextAsync([In] IStorageFile file);
        [Overload("ReadTextWithEncodingAsync")]
        IAsyncOperation<string> ReadTextAsync([In] IStorageFile file, [In] UnicodeEncoding encoding);
        IAsyncAction WriteBufferAsync([In] IStorageFile file, [In] IBuffer buffer);
        IAsyncAction WriteBytesAsync([In] IStorageFile file, [In] byte[] buffer);
        [Overload("WriteLinesAsync")]
        IAsyncAction WriteLinesAsync([In] IStorageFile file, [In] IIterable<string> lines);
        [Overload("WriteLinesWithEncodingAsync")]
        IAsyncAction WriteLinesAsync([In] IStorageFile file, [In] IIterable<string> lines, [In] UnicodeEncoding encoding);
        [Overload("WriteTextAsync")]
        IAsyncAction WriteTextAsync([In] IStorageFile file, [In] string contents);
        [Overload("WriteTextWithEncodingAsync")]
        IAsyncAction WriteTextAsync([In] IStorageFile file, [In] string contents, [In] UnicodeEncoding encoding);
    }
}

