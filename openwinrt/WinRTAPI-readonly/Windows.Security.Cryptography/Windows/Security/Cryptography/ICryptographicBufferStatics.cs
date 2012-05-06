namespace Windows.Security.Cryptography
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [ExclusiveTo(typeof(CryptographicBuffer)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x320b7e22, 0x3cb0, 0x4cdf, 0x86, 0x63, 0x1d, 40, 0x91, 0, 0x65, 0xeb)]
    internal interface ICryptographicBufferStatics
    {
        bool Compare([In] IBuffer object1, [In] IBuffer object2);
        string ConvertBinaryToString([In] BinaryStringEncoding encoding, [In] IBuffer buffer);
        IBuffer ConvertStringToBinary([In] string value, [In] BinaryStringEncoding encoding);
        void CopyToByteArray([In] IBuffer buffer, out byte[] value);
        IBuffer CreateFromByteArray([In] byte[] value);
        IBuffer DecodeFromBase64String([In] string value);
        IBuffer DecodeFromHexString([In] string value);
        string EncodeToBase64String([In] IBuffer buffer);
        string EncodeToHexString([In] IBuffer buffer);
        IBuffer GenerateRandom([In] uint length);
        uint GenerateRandomNumber();
    }
}

