namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(CarouselPanel)), WebHostHidden, Windows.Foundation.Metadata.Guid(0xc1109404, 0x9ae1, 0x440e, 160, 0xdd, 0xbb, 0xb6, 0xe2, 0x29, 60, 190)]
    internal interface ICarouselPanelFactory
    {
        CarouselPanel CreateInstance([In] object outer, out object inner);
    }
}

