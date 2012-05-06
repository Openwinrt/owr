namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(TapDownThemeAnimation)), WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0xb58e714e, 0xc49d, 0x4788, 0xa2, 0x33, 10, 0xe8, 0x5d, 0x99, 0xdd, 90)]
    internal interface ITapDownThemeAnimation
    {
        string TargetName { get; [param: In] set; }
    }
}

