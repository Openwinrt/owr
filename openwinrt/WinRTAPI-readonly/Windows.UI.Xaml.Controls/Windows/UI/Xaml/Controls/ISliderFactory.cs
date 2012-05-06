namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(Slider)), Windows.Foundation.Metadata.Guid(0x3a67b37, 0xc7bf, 0x437c, 0x84, 0x8f, 140, 0xb5, 0xb7, 0x53, 0xea, 180), WebHostHidden]
    internal interface ISliderFactory
    {
        Slider CreateInstance([In] object outer, out object inner);
    }
}

