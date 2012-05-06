namespace Windows.UI.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(PointerPoint)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xa506638d, 0x2a1a, 0x413e, 0xbc, 0x75, 0x9f, 0x38, 0x38, 0x1c, 0xc0, 0x69)]
    internal interface IPointerPointStatics
    {
        [DefaultOverload, Overload("GetCurrentPoint")]
        PointerPoint GetCurrentPoint([In] uint pointerId);
        [Overload("GetCurrentPointTransformed")]
        PointerPoint GetCurrentPoint([In] uint pointerId, [In] IPointerPointTransform transform);
        [DefaultOverload, Overload("GetIntermediatePoints")]
        IVector<PointerPoint> GetIntermediatePoints([In] uint pointerId);
        [Overload("GetIntermediatePointsTransformed")]
        IVector<PointerPoint> GetIntermediatePoints([In] uint pointerId, [In] IPointerPointTransform transform);
    }
}

