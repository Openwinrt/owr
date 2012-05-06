namespace Windows.Storage.Streams
{
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(DataReader)), Windows.Foundation.Metadata.Guid(0x11fcbfc8, 0xf93a, 0x471b, 0xb1, 0x21, 0xf3, 0x79, 0xe3, 0x49, 0x31, 60)]
    internal interface IDataReaderStatics
    {
        DataReader FromBuffer([In] IBuffer buffer);
    }
}

