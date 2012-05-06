namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Media.Capture;
    using Windows.UI.Xaml.Media;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x31a5c0e7, 0xf307, 0x4d4a, 0xb6, 0x26, 0xe9, 120, 0x86, 0x3f, 0x5b, 0x74), ExclusiveTo(typeof(CaptureElement)), WebHostHidden]
    internal interface ICaptureElement
    {
        MediaCapture Source { get; [param: In] set; }

        Windows.UI.Xaml.Media.Stretch Stretch { get; [param: In] set; }
    }
}

