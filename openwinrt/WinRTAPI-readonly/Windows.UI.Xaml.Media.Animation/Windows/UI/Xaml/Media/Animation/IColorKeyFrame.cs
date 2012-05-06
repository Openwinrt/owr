namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0xb51d82d9, 0x910, 0x4589, 0xa2, 0x84, 0xb0, 0xc9, 0x20, 0x58, 0x58, 0xe9), ExclusiveTo(typeof(ColorKeyFrame)), Version(0x6020000)]
    internal interface IColorKeyFrame
    {
        Windows.UI.Xaml.Media.Animation.KeyTime KeyTime { get; [param: In] set; }

        Color Value { get; [param: In] set; }
    }
}

