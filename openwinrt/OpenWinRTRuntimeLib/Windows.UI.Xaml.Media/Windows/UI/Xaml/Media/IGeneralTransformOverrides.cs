namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x4f121083, 0x24cf, 0x4524, 0x90, 0xad, 0x8a, 0x42, 0xb1, 0xc1, 0x27, 0x83), Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(GeneralTransform))]
    internal interface IGeneralTransformOverrides
    {
        Rect TransformBoundsCore([In] Rect rect);
        bool TryTransformCore([In] Point inPoint, out Point outPoint);

        GeneralTransform InverseCore { get; }
    }
}

