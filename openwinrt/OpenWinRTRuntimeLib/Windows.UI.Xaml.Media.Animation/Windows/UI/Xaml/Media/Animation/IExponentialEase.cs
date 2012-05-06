namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(ExponentialEase)), Windows.Foundation.Metadata.Guid(0x7cb9e41d, 0xf0bb, 0x4bca, 0x9d, 0xa5, 0x9b, 0xa3, 0xa1, 0x17, 0x34, 0xc4)]
    internal interface IExponentialEase
    {
        double Exponent { get; [param: In] set; }
    }
}

