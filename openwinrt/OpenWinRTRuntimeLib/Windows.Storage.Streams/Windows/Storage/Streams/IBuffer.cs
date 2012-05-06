namespace Windows.Storage.Streams
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x905a0fe0, 0xbc53, 0x11df, 140, 0x49, 0, 30, 0x4f, 0xc6, 0x86, 0xda), Version(0x6020000)]
    public interface IBuffer
    {
        uint Capacity { get; }

        uint Length { get; [param: In] set; }
    }
}

