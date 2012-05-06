namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(KeySpline)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x77a163bb, 0xd5ca, 0x4a32, 0xba, 11, 0x7d, 0xff, 0x98, 0x8e, 0x58, 160), WebHostHidden]
    internal interface IKeySpline
    {
        Point ControlPoint1 { get; [param: In] set; }

        Point ControlPoint2 { get; [param: In] set; }
    }
}

