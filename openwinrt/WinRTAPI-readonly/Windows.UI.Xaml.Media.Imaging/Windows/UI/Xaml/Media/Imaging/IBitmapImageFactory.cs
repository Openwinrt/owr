namespace Windows.UI.Xaml.Media.Imaging
{
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xc9132978, 0x4810, 0x4e5e, 0x80, 0x87, 3, 0x67, 30, 230, 13, 0x85), WebHostHidden, ExclusiveTo(typeof(BitmapImage)), Version(0x6020000)]
    internal interface IBitmapImageFactory
    {
        BitmapImage CreateInstanceWithUriSource([In] Uri uriSource);
    }
}

