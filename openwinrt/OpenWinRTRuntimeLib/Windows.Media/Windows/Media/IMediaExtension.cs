namespace Windows.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x7915118, 0x45df, 0x442b, 0x8a, 0x3f, 0xf7, 130, 0x6a, 0x63, 0x70, 0xab)]
    public interface IMediaExtension
    {
        void SetProperties([In] IPropertySet configuration);
    }
}

