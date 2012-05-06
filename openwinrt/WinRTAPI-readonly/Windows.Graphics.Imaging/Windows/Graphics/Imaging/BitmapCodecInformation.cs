namespace Windows.Graphics.Imaging
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class BitmapCodecInformation : IBitmapCodecInformation
    {
        public Guid CodecId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<string> FileExtensions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string FriendlyName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<string> MimeTypes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Guid Windows.Graphics.Imaging.IBitmapCodecInformation.CodecId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<string> Windows.Graphics.Imaging.IBitmapCodecInformation.FileExtensions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Graphics.Imaging.IBitmapCodecInformation.FriendlyName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<string> Windows.Graphics.Imaging.IBitmapCodecInformation.MimeTypes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

