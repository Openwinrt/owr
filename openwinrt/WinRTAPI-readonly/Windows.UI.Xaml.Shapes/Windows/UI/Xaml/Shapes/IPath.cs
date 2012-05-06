namespace Windows.UI.Xaml.Shapes
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Media;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(Path)), Windows.Foundation.Metadata.Guid(0x78883609, 0x3d57, 0x4f3c, 0xb8, 0xa5, 0x6c, 0xab, 0xca, 0xc9, 0x71, 0x1f)]
    internal interface IPath
    {
        Geometry Data { get; [param: In] set; }
    }
}

