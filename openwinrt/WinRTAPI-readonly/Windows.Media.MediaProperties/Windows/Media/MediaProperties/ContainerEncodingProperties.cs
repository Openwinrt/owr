namespace Windows.Media.MediaProperties
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Activatable(0x6020000), Threading(ThreadingModel.Both), Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class ContainerEncodingProperties : IContainerEncodingProperties, IMediaEncodingProperties
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ContainerEncodingProperties();

        public MediaPropertySet Properties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Subtype { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaPropertySet Windows.Media.MediaProperties.IMediaEncodingProperties.Properties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Media.MediaProperties.IMediaEncodingProperties.Subtype { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Media.MediaProperties.IMediaEncodingProperties.Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

