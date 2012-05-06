namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(DoubleKeyFrame)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xac97dec3, 0x7538, 0x40b9, 0xb1, 0x52, 0x69, 0x6f, 0x7f, 0xbf, 0x47, 0x22), WebHostHidden]
    internal interface IDoubleKeyFrameFactory
    {
        DoubleKeyFrame CreateInstance([In] object outer, out object inner);
    }
}

