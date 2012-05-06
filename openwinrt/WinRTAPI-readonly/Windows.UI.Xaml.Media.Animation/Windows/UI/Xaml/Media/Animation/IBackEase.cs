namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0xe47796e7, 0xf805, 0x4a8f, 0x81, 0xc9, 0x38, 230, 0x47, 0x2c, 170, 0x94), ExclusiveTo(typeof(BackEase))]
    internal interface IBackEase
    {
        double Amplitude { get; [param: In] set; }
    }
}

