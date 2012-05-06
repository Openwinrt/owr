namespace Windows.UI.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x22f3b823, 0xb7c, 0x424e, 0x9d, 0xf7, 0x33, 0xd4, 0xf9, 0x62, 0x93, 0x1b), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(TouchHitTestingEventArgs))]
    internal interface ITouchHitTestingEventArgs : ICoreWindowEventArgs
    {
        [Overload("EvaluateProximityToRect"), DefaultOverload]
        CoreProximityEvaluation EvaluateProximity([In] Rect controlBoundingBox);
        [Overload("EvaluateProximityToPolygon")]
        CoreProximityEvaluation EvaluateProximity([In] Windows.Foundation.Point[] controlVertices);

        Rect BoundingBox { get; }

        Windows.Foundation.Point Point { get; }

        CoreProximityEvaluation ProximityEvaluation { get; [param: In] set; }
    }
}

