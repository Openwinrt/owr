namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), WebHostHidden, Threading(ThreadingModel.Both)]
    public sealed class ProgressRingTemplateSettings : DependencyObject, IProgressRingTemplateSettings
    {
        public double EllipseDiameter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Thickness EllipseOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double MaxSideLength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IProgressRingTemplateSettings.EllipseDiameter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Thickness Windows.UI.Xaml.Controls.Primitives.IProgressRingTemplateSettings.EllipseOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IProgressRingTemplateSettings.MaxSideLength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

