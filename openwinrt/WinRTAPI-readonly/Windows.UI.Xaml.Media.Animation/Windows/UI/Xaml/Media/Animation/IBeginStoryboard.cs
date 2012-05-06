namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(BeginStoryboard)), Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x64189fcd, 0x49ec, 0x4e52, 0xa6, 0xf6, 0x55, 50, 0x4c, 0x92, 0x10, 0x53)]
    internal interface IBeginStoryboard
    {
        Windows.UI.Xaml.Media.Animation.Storyboard Storyboard { get; [param: In] set; }
    }
}

