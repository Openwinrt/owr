namespace Windows.UI.Input.Inking
{
    using System;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x68510f1f, 0x88e3, 0x477a, 0xa2, 250, 0x56, 0x9f, 0x5f, 0x1f, 0x9b, 0xd5)]
    public interface IInkStrokeRenderingSegment
    {
        Point BezierControlPoint1 { get; }

        Point BezierControlPoint2 { get; }

        Point Position { get; }

        float Pressure { get; }

        float TiltX { get; }

        float TiltY { get; }

        float Twist { get; }
    }
}

