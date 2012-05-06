namespace Windows.Security.Cryptography.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [ExclusiveTo(typeof(CryptographicHash)), Windows.Foundation.Metadata.Guid(0x5904d1b6, 0xad31, 0x4603, 0xa3, 0xa4, 0xb1, 0xbd, 0xa9, 0x8e, 0x25, 0x62), Version(0x6020000)]
    internal interface IHashComputation
    {
        void Append([In] IBuffer data);
        IBuffer GetValueAndReset();
    }
}

