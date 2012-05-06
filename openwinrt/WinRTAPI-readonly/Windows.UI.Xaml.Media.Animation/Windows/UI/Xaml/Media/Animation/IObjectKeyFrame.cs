namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x9852a851, 0x8593, 0x48ee, 0xa6, 0xa4, 0xd5, 0xd4, 0x72, 15, 2, 0x9a), ExclusiveTo(typeof(ObjectKeyFrame))]
    internal interface IObjectKeyFrame
    {
        Windows.UI.Xaml.Media.Animation.KeyTime KeyTime { get; [param: In] set; }

        object Value { get; [param: In] set; }
    }
}

