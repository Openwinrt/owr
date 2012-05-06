namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xe9e9d07d, 0x6340, 0x4828, 0xad, 0x12, 0x69, 6, 0x94, 0xb9, 0x91, 11), ExclusiveTo(typeof(TapUpThemeAnimation)), WebHostHidden]
    internal interface ITapUpThemeAnimation
    {
        string TargetName { get; [param: In] set; }
    }
}

