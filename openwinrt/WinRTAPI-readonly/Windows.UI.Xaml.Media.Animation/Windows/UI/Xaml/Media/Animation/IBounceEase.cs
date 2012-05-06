namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x2bf1464e, 0xfc71, 0x47ed, 0x85, 0xa1, 0x3b, 0xa9, 0x57, 0x77, 0x18, 180), ExclusiveTo(typeof(BounceEase)), WebHostHidden, Version(0x6020000)]
    internal interface IBounceEase
    {
        int Bounces { get; [param: In] set; }

        double Bounciness { get; [param: In] set; }
    }
}

