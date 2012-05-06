namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(DoubleKeyFrame)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x674456fd, 0xe81e, 0x4f4e, 180, 0xad, 10, 0xcf, 0xed, 0x9e, 0xcd, 0x68), Version(0x6020000)]
    internal interface IDoubleKeyFrame
    {
        Windows.UI.Xaml.Media.Animation.KeyTime KeyTime { get; [param: In] set; }

        double Value { get; [param: In] set; }
    }
}

