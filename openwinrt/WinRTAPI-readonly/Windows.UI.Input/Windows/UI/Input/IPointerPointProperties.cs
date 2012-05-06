namespace Windows.UI.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x44bbd531, 0xdabd, 0x4b51, 0x81, 0xe7, 0xbc, 0xdf, 0xda, 0xf7, 230, 0x2f), ExclusiveTo(typeof(PointerPointProperties)), Version(0x6020000)]
    internal interface IPointerPointProperties
    {
        int GetUsageValue([In] uint usagePage, [In] uint usageId);
        bool HasUsage([In] uint usagePage, [In] uint usageId);

        Rect ContactRect { get; }

        Rect ContactRectRaw { get; }

        bool IsBarrelButtonPressed { get; }

        bool IsCanceled { get; }

        bool IsEraser { get; }

        bool IsHorizontalMouseWheel { get; }

        bool IsInRange { get; }

        bool IsInverted { get; }

        bool IsLeftButtonPressed { get; }

        bool IsMiddleButtonPressed { get; }

        bool IsPrimary { get; }

        bool IsRightButtonPressed { get; }

        int MouseWheelDelta { get; }

        float Orientation { get; }

        float Pressure { get; }

        bool TouchConfidence { get; }

        float Twist { get; }

        float XTilt { get; }

        float YTilt { get; }
    }
}

