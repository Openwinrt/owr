namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Activatable(0x6020000), Threading(ThreadingModel.Both), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class ScrollViewerViewChangedEventArgs : IScrollViewerViewChangedEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ScrollViewerViewChangedEventArgs();

        public bool IsIntermediate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.IScrollViewerViewChangedEventArgs.IsIntermediate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

