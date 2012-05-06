namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(GeneralTransform)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x7a25c930, 0x29c4, 0x4e31, 0xb6, 0xf9, 0xde, 0xdd, 0x52, 0xe4, 0xdf, 0x1b), WebHostHidden]
    internal interface IGeneralTransformFactory
    {
        GeneralTransform CreateInstance([In] object outer, out object inner);
    }
}

