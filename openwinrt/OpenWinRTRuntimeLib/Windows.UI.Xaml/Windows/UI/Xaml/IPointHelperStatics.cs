namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x15aca75, 0x76d8, 0x4b7e, 0x8a, 0x33, 0x7d, 0x79, 0x20, 70, 0x91, 0xee), ExclusiveTo(typeof(PointHelper)), WebHostHidden]
    internal interface IPointHelperStatics
    {
        Point FromCoordinates([In] float x, [In] float y);
    }
}

