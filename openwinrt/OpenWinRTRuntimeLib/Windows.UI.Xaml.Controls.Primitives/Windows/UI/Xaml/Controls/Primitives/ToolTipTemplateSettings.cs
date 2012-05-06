namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Threading(ThreadingModel.Both), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class ToolTipTemplateSettings : DependencyObject, IToolTipTemplateSettings
    {
        public double FromHorizontalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double FromVerticalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double ToHorizontalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double ToVerticalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IToolTipTemplateSettings.FromHorizontalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IToolTipTemplateSettings.FromVerticalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IToolTipTemplateSettings.ToHorizontalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IToolTipTemplateSettings.ToVerticalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

