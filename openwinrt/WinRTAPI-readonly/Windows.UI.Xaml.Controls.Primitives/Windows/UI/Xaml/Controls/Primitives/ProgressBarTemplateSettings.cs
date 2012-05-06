namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Version(0x6020000)]
    public sealed class ProgressBarTemplateSettings : DependencyObject, IProgressBarTemplateSettings
    {
        public double ContainerAnimationEndPosition { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double ContainerAnimationStartPosition { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double EllipseAnimationEndPosition { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double EllipseAnimationWellPosition { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double EllipseDiameter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double EllipseOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double IndicatorLengthDelta { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IProgressBarTemplateSettings.ContainerAnimationEndPosition { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IProgressBarTemplateSettings.ContainerAnimationStartPosition { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IProgressBarTemplateSettings.EllipseAnimationEndPosition { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IProgressBarTemplateSettings.EllipseAnimationWellPosition { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IProgressBarTemplateSettings.EllipseDiameter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IProgressBarTemplateSettings.EllipseOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IProgressBarTemplateSettings.IndicatorLengthDelta { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

