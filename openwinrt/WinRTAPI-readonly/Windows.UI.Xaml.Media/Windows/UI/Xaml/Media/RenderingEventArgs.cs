namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Threading(ThreadingModel.Both), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class RenderingEventArgs : IRenderingEventArgs
    {
        public Windows.Foundation.TimeSpan RenderingTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.TimeSpan Windows.UI.Xaml.Media.IRenderingEventArgs.RenderingTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

