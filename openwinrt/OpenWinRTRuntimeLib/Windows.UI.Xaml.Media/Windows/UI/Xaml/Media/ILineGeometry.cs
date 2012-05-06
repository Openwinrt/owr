namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(LineGeometry)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x30edd4a2, 0x8fc5, 0x40af, 0xa7, 0xa2, 0xc2, 0x7f, 0xe7, 170, 0x13, 0x63)]
    internal interface ILineGeometry
    {
        Point EndPoint { get; [param: In] set; }

        Point StartPoint { get; [param: In] set; }
    }
}

