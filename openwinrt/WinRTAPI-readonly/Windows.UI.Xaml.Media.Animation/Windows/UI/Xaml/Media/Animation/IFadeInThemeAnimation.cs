namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(FadeInThemeAnimation)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x6d4bc8f5, 0xa918, 0x4477, 0x80, 120, 0x55, 0x4c, 0x68, 0x81, 0x2a, 0xb8), Version(0x6020000)]
    internal interface IFadeInThemeAnimation
    {
        string TargetName { get; [param: In] set; }
    }
}

