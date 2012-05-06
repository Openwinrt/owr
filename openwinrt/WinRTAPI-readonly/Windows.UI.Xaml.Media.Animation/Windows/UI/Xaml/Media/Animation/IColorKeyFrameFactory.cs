namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x769bd88a, 0x9cfb, 0x4a7d, 150, 0xc4, 0xa1, 0xe7, 0xde, 0x6f, 0xdb, 0x4b), WebHostHidden, ExclusiveTo(typeof(ColorKeyFrame)), Version(0x6020000)]
    internal interface IColorKeyFrameFactory
    {
        ColorKeyFrame CreateInstance([In] object outer, out object inner);
    }
}

