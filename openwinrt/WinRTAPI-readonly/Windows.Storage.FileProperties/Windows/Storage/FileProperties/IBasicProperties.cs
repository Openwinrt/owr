namespace Windows.Storage.FileProperties
{
    using System;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0xd05d55db, 0x785e, 0x4a66, 190, 2, 0x9b, 0xee, 0xc5, 0x8a, 0xea, 0x81), ExclusiveTo(typeof(BasicProperties))]
    internal interface IBasicProperties
    {
        Windows.Foundation.DateTime DateModified { get; }

        ulong Size { get; }
    }
}

