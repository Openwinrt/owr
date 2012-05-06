namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(PowerEase)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x69c80579, 0xeedf, 0x405b, 0x86, 0x80, 0xd9, 0x60, 0x68, 0x80, 0xc9, 0x37)]
    internal interface IPowerEase
    {
        double Power { get; [param: In] set; }
    }
}

