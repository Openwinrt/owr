namespace Windows.UI.Input
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Devices.Input;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Static(typeof(IPointerPointStatics), 0x6020000)]
    public sealed class PointerPoint : IPointerPoint
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("GetCurrentPoint")]
        public static PointerPoint GetCurrentPoint([In] uint pointerId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetCurrentPointTransformed")]
        public static PointerPoint GetCurrentPoint([In] uint pointerId, [In] IPointerPointTransform transform);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("GetIntermediatePoints")]
        public static IVector<PointerPoint> GetIntermediatePoints([In] uint pointerId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetIntermediatePointsTransformed")]
        public static IVector<PointerPoint> GetIntermediatePoints([In] uint pointerId, [In] IPointerPointTransform transform);

        public uint FrameId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsInContact { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Devices.Input.PointerDevice PointerDevice { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint PointerId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Position { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PointerPointProperties Properties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point RawPosition { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ulong Timestamp { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.UI.Input.IPointerPoint.FrameId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Input.IPointerPoint.IsInContact { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Devices.Input.PointerDevice Windows.UI.Input.IPointerPoint.PointerDevice { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.UI.Input.IPointerPoint.PointerId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Windows.UI.Input.IPointerPoint.Position { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PointerPointProperties Windows.UI.Input.IPointerPoint.Properties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Windows.UI.Input.IPointerPoint.RawPosition { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ulong Windows.UI.Input.IPointerPoint.Timestamp { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

