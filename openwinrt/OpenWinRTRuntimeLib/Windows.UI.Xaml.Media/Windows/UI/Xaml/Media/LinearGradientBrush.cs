namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Threading(ThreadingModel.Both), Static(typeof(ILinearGradientBrushStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Activatable(0x6020000), Activatable(typeof(ILinearGradientBrushFactory), 0x6020000), WebHostHidden]
    public sealed class LinearGradientBrush : GradientBrush, ILinearGradientBrush
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public LinearGradientBrush();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public LinearGradientBrush([In] GradientStopCollection gradientStopCollection, [In] double angle);

        public Point EndPoint { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty EndPointProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point StartPoint { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty StartPointProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Windows.UI.Xaml.Media.ILinearGradientBrush.EndPoint { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Point Windows.UI.Xaml.Media.ILinearGradientBrush.StartPoint { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

