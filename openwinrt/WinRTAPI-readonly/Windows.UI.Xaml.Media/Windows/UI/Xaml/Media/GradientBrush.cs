namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Markup;

    [Composable(typeof(IGradientBrushFactory), CompositionType.Protected, 0x6020000), Version(0x6020000), Static(typeof(IGradientBrushStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), ContentProperty(Name="GradientStops"), WebHostHidden]
    public class GradientBrush : Brush, IGradientBrush
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected GradientBrush();

        public Windows.UI.Xaml.Media.ColorInterpolationMode ColorInterpolationMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ColorInterpolationModeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public GradientStopCollection GradientStops { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty GradientStopsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public BrushMappingMode MappingMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty MappingModeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public GradientSpreadMethod SpreadMethod { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty SpreadMethodProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.ColorInterpolationMode Windows.UI.Xaml.Media.IGradientBrush.ColorInterpolationMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public GradientStopCollection Windows.UI.Xaml.Media.IGradientBrush.GradientStops { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public BrushMappingMode Windows.UI.Xaml.Media.IGradientBrush.MappingMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public GradientSpreadMethod Windows.UI.Xaml.Media.IGradientBrush.SpreadMethod { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

