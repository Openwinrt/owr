namespace Windows.UI.Input
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class EdgeGestureEventArgs : IEdgeGestureEventArgs
    {
        public EdgeGestureKind Kind { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public EdgeGestureKind Windows.UI.Input.IEdgeGestureEventArgs.Kind { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

