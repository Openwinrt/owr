namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI;

    [Version(0x6020000), ExclusiveTo(typeof(SolidColorBrush)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x9d850850, 0x66f3, 0x48df, 0x9a, 0x8f, 130, 0x4b, 0xd5, 0xe0, 0x70, 0xaf)]
    internal interface ISolidColorBrush
    {
        Windows.UI.Color Color { get; [param: In] set; }
    }
}

