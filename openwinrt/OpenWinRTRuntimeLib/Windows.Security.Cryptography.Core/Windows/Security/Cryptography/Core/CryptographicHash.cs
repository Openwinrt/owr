namespace Windows.Security.Cryptography.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Version(0x6020000), DualApiPartition(version=0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class CryptographicHash : IHashComputation
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Append([In] IBuffer data);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IBuffer GetValueAndReset();
    }
}

