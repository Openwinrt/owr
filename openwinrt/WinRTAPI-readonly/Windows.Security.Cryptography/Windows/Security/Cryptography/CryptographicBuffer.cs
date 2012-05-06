namespace Windows.Security.Cryptography
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Threading(ThreadingModel.Both), DualApiPartition(version=0x6020000), Static(typeof(ICryptographicBufferStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public static class CryptographicBuffer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool Compare([In] IBuffer object1, [In] IBuffer object2);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string ConvertBinaryToString([In] BinaryStringEncoding encoding, [In] IBuffer buffer);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IBuffer ConvertStringToBinary([In] string value, [In] BinaryStringEncoding encoding);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void CopyToByteArray([In] IBuffer buffer, out byte[] value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IBuffer CreateFromByteArray([In] byte[] value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IBuffer DecodeFromBase64String([In] string value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IBuffer DecodeFromHexString([In] string value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string EncodeToBase64String([In] IBuffer buffer);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string EncodeToHexString([In] IBuffer buffer);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IBuffer GenerateRandom([In] uint length);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static uint GenerateRandomNumber();
    }
}

