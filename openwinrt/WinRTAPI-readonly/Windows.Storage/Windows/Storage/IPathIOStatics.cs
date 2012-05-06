namespace Windows.Storage
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [ExclusiveTo(typeof(PathIO)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xf2f3758, 0x8ec7, 0x4381, 0x92, 0x2b, 0x8f, 0x6c, 7, 210, 0x88, 0xf3)]
    internal interface IPathIOStatics
    {
        [Overload("AppendLinesAsync")]
        IAsyncAction AppendLinesAsync([In] string absolutePath, [In] IIterable<string> lines);
        [Overload("AppendLinesWithEncodingAsync")]
        IAsyncAction AppendLinesAsync([In] string absolutePath, [In] IIterable<string> lines, [In] UnicodeEncoding encoding);
        [Overload("AppendTextAsync")]
        IAsyncAction AppendTextAsync([In] string absolutePath, [In] string contents);
        [Overload("AppendTextWithEncodingAsync")]
        IAsyncAction AppendTextAsync([In] string absolutePath, [In] string contents, [In] UnicodeEncoding encoding);
        IAsyncOperation<IBuffer> ReadBufferAsync([In] string absolutePath);
        [Overload("ReadLinesAsync")]
        IAsyncOperation<IVector<string>> ReadLinesAsync([In] string absolutePath);
        [Overload("ReadLinesWithEncodingAsync")]
        IAsyncOperation<IVector<string>> ReadLinesAsync([In] string absolutePath, [In] UnicodeEncoding encoding);
        [Overload("ReadTextAsync")]
        IAsyncOperation<string> ReadTextAsync([In] string absolutePath);
        [Overload("ReadTextWithEncodingAsync")]
        IAsyncOperation<string> ReadTextAsync([In] string absolutePath, [In] UnicodeEncoding encoding);
        IAsyncAction WriteBufferAsync([In] string absolutePath, [In] IBuffer buffer);
        IAsyncAction WriteBytesAsync([In] string absolutePath, [In] byte[] buffer);
        [Overload("WriteLinesAsync")]
        IAsyncAction WriteLinesAsync([In] string absolutePath, [In] IIterable<string> lines);
        [Overload("WriteLinesWithEncodingAsync")]
        IAsyncAction WriteLinesAsync([In] string absolutePath, [In] IIterable<string> lines, [In] UnicodeEncoding encoding);
        [Overload("WriteTextAsync")]
        IAsyncAction WriteTextAsync([In] string absolutePath, [In] string contents);
        [Overload("WriteTextWithEncodingAsync")]
        IAsyncAction WriteTextAsync([In] string absolutePath, [In] string contents, [In] UnicodeEncoding encoding);
    }
}

