namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x42011736, 0xe3c2, 0x496b, 0xbc, 0x4e, 0xd7, 80, 0xd4, 0x37, 0x5b, 0x9a), ExclusiveTo(typeof(SemanticZoomLocation)), Version(0x6020000), WebHostHidden]
    internal interface ISemanticZoomLocation
    {
        Rect Bounds { get; [param: In] set; }

        object Item { get; [param: In] set; }
    }
}

