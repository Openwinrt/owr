namespace Windows.Storage.Streams
{
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xd7527847, 0x57da, 0x4e15, 0x91, 0x4c, 6, 0x80, 0x66, 0x99, 160, 0x98), ExclusiveTo(typeof(DataReader))]
    internal interface IDataReaderFactory
    {
        DataReader CreateDataReader([In] IInputStream inputStream);
    }
}

