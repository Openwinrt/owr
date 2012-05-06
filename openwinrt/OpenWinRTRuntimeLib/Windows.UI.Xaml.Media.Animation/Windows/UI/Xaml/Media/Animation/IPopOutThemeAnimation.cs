namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x4786ab49, 0xe48, 0x4e81, 0xa2, 0xe5, 0xcc, 90, 0xa1, 0x9e, 0x48, 0xd3), ExclusiveTo(typeof(PopOutThemeAnimation))]
    internal interface IPopOutThemeAnimation
    {
        string TargetName { get; [param: In] set; }
    }
}

