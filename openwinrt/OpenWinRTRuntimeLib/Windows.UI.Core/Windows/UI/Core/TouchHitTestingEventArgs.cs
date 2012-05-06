namespace Windows.UI.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden]
    public sealed class TouchHitTestingEventArgs : ITouchHitTestingEventArgs, ICoreWindowEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("EvaluateProximityToRect")]
        public CoreProximityEvaluation EvaluateProximity([In] Rect controlBoundingBox);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("EvaluateProximityToPolygon")]
        public CoreProximityEvaluation EvaluateProximity([In] Windows.Foundation.Point[] controlVertices);

        public Rect BoundingBox { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Foundation.Point Point { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public CoreProximityEvaluation ProximityEvaluation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Core.ICoreWindowEventArgs.Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Rect Windows.UI.Core.ITouchHitTestingEventArgs.BoundingBox { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.Point Windows.UI.Core.ITouchHitTestingEventArgs.Point { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public CoreProximityEvaluation Windows.UI.Core.ITouchHitTestingEventArgs.ProximityEvaluation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

