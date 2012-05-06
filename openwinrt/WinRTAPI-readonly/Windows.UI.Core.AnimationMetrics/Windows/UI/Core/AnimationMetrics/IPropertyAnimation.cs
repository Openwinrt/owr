namespace Windows.UI.Core.AnimationMetrics
{
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Guid(0x3a01b4da, 0x4d8c, 0x411e, 0xb6, 0x15, 0x1a, 0xde, 0x68, 0x3a, 0x99, 3), Version(0x6020000)]
    public interface IPropertyAnimation
    {
        Point Control1 { get; }

        Point Control2 { get; }

        TimeSpan Delay { get; }

        TimeSpan Duration { get; }

        PropertyAnimationType Type { get; }
    }
}

