namespace Windows.Storage.Streams
{
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(DataWriter)), Windows.Foundation.Metadata.Guid(0x338c67c2, 0x8b84, 0x4c2b, 0x9c, 80, 0x7b, 0x87, 0x67, 0x84, 0x7a, 0x1f), Version(0x6020000)]
    internal interface IDataWriterFactory
    {
        DataWriter CreateDataWriter([In] IOutputStream outputStream);
    }
}

