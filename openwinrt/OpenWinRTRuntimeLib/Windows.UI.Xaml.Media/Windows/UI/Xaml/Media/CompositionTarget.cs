namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), Static(typeof(ICompositionTargetStatics), 0x6020000), WebHostHidden, Version(0x6020000)]
    public sealed class CompositionTarget : ICompositionTarget
    {
        public static  event Windows.Foundation.EventHandler<object> Rendering;

        public static  event Windows.Foundation.EventHandler<object> SurfaceContentsLost;
    }
}

