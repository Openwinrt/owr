namespace Windows.UI.Input
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class PointerPointProperties : IPointerPointProperties
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public int GetUsageValue([In] uint usagePage, [In] uint usageId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool HasUsage([In] uint usagePage, [In] uint usageId);

        public Rect ContactRect { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Rect ContactRectRaw { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsBarrelButtonPressed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsCanceled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsEraser { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsHorizontalMouseWheel { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsInRange { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsInverted { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsLeftButtonPressed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsMiddleButtonPressed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsPrimary { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsRightButtonPressed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int MouseWheelDelta { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Orientation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Pressure { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool TouchConfidence { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Twist { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Rect Windows.UI.Input.IPointerPointProperties.ContactRect { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Rect Windows.UI.Input.IPointerPointProperties.ContactRectRaw { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Input.IPointerPointProperties.IsBarrelButtonPressed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Input.IPointerPointProperties.IsCanceled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Input.IPointerPointProperties.IsEraser { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Input.IPointerPointProperties.IsHorizontalMouseWheel { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Input.IPointerPointProperties.IsInRange { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Input.IPointerPointProperties.IsInverted { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Input.IPointerPointProperties.IsLeftButtonPressed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Input.IPointerPointProperties.IsMiddleButtonPressed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Input.IPointerPointProperties.IsPrimary { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Input.IPointerPointProperties.IsRightButtonPressed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Input.IPointerPointProperties.MouseWheelDelta { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.UI.Input.IPointerPointProperties.Orientation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.UI.Input.IPointerPointProperties.Pressure { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Input.IPointerPointProperties.TouchConfidence { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.UI.Input.IPointerPointProperties.Twist { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.UI.Input.IPointerPointProperties.XTilt { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.UI.Input.IPointerPointProperties.YTilt { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float XTilt { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float YTilt { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

