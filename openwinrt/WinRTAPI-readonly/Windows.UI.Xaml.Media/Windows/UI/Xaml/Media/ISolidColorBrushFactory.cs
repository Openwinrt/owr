namespace Windows.UI.Xaml.Media
{
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI;

    [Version(0x6020000), ExclusiveTo(typeof(SolidColorBrush)), Windows.Foundation.Metadata.Guid(0xd935ce0c, 0x86f5, 0x4da6, 0x8a, 0x27, 0xb1, 0x61, 0x9e, 0xf7, 0xf9, 0x2b), WebHostHidden]
    internal interface ISolidColorBrushFactory
    {
        SolidColorBrush CreateInstanceWithColor([In] Color color);
    }
}

