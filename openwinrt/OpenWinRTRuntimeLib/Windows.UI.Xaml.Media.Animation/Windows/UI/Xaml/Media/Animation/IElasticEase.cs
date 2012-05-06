namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(ElasticEase)), WebHostHidden, Windows.Foundation.Metadata.Guid(0xef5ba58c, 0xb0b6, 0x4a6c, 0x9c, 0xa8, 0xfb, 0x42, 0x33, 0xf1, 0x24, 0x59)]
    internal interface IElasticEase
    {
        int Oscillations { get; [param: In] set; }

        double Springiness { get; [param: In] set; }
    }
}

