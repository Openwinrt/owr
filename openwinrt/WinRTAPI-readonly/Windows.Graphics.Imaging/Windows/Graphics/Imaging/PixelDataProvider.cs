namespace Windows.Graphics.Imaging
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class PixelDataProvider : IPixelDataProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public byte[] DetachPixelData();
    }
}

