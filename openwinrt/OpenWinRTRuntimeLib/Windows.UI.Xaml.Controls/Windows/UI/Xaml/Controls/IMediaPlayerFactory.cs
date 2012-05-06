namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xc9fcab43, 0xf0ba, 0x44f3, 0x93, 12, 0x9f, 0x9b, 0xa7, 0xfb, 0x25, 0xc5), ExclusiveTo(typeof(MediaPlayer)), WebHostHidden]
    internal interface IMediaPlayerFactory
    {
        MediaPlayer CreateInstance([In] object outer, out object inner);
    }
}

