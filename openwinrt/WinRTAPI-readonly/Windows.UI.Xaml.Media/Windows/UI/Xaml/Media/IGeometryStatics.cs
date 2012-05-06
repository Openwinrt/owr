namespace Windows.UI.Xaml.Media
{
    using System;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Guid(0x7a70aa8c, 0xb06, 0x465f, 0xb6, 0x37, 0x9a, 0x47, 0xe5, 0xa7, 1, 0x11), Version(0x6020000), ExclusiveTo(typeof(Geometry)), WebHostHidden]
    internal interface IGeometryStatics
    {
        Geometry Empty { get; }

        double StandardFlatteningTolerance { get; }

        DependencyProperty TransformProperty { get; }
    }
}

