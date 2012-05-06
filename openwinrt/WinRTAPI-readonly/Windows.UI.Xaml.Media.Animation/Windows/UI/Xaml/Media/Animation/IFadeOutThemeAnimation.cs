namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(FadeOutThemeAnimation)), Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x89276ba9, 0xffd4, 0x45b6, 0x9b, 0x9a, 0xce, 0xd4, 0x89, 0x51, 0xe7, 0x12)]
    internal interface IFadeOutThemeAnimation
    {
        string TargetName { get; [param: In] set; }
    }
}

