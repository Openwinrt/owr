namespace Windows.UI.Xaml.Media.Imaging
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xe240420e, 0xd4a7, 0x49a4, 160, 180, 0xa5, 0x9f, 0xdd, 0x77, 0xe5, 8), ExclusiveTo(typeof(BitmapSource)), WebHostHidden, Version(0x6020000)]
    internal interface IBitmapSourceFactory
    {
        BitmapSource CreateInstance([In] object outer, out object inner);
    }
}

