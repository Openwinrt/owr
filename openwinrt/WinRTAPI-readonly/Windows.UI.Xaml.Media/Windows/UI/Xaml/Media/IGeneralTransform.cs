namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xa06798b7, 0xa2ec, 0x415f, 0xad, 0xe2, 0xea, 0xde, 0x93, 0x33, 0xf2, 0xc7), Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(GeneralTransform))]
    internal interface IGeneralTransform
    {
        Rect TransformBounds([In] Rect rect);
        Point TransformPoint([In] Point point);
        bool TryTransform([In] Point inPoint, out Point outPoint);

        GeneralTransform Inverse { get; }
    }
}

