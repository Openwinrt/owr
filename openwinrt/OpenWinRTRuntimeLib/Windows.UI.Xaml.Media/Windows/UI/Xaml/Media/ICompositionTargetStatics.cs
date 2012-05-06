namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(CompositionTarget)), Windows.Foundation.Metadata.Guid(0x2b1af03d, 0x1ed2, 0x4b59, 0xbd, 0, 0x75, 0x94, 0xee, 0x92, 0x83, 0x2b)]
    internal interface ICompositionTargetStatics
    {
        event Windows.Foundation.EventHandler<object> Rendering;

        event Windows.Foundation.EventHandler<object> SurfaceContentsLost;
    }
}

