namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x1d56bb07, 0xbda4, 0x478b, 0x8a, 0xda, 0xeb, 4, 0xd5, 0x80, 0xcd, 0x5e), WebHostHidden, ExclusiveTo(typeof(Timeline))]
    internal interface ITimelineFactory
    {
        Timeline CreateInstance([In] object outer, out object inner);
    }
}

