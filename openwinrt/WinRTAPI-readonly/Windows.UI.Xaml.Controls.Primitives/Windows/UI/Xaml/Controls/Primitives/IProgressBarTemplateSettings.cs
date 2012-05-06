namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x3fe2ea2a, 0xe3f2, 0x4c2b, 0x94, 0x88, 0x91, 0x8d, 0x77, 210, 0xbb, 0xe4), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(ProgressBarTemplateSettings))]
    internal interface IProgressBarTemplateSettings
    {
        double ContainerAnimationEndPosition { get; }

        double ContainerAnimationStartPosition { get; }

        double EllipseAnimationEndPosition { get; }

        double EllipseAnimationWellPosition { get; }

        double EllipseDiameter { get; }

        double EllipseOffset { get; }

        double IndicatorLengthDelta { get; }
    }
}

