namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Threading(ThreadingModel.Both), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Static(typeof(IRotateTransformStatics), 0x6020000), Activatable(0x6020000), WebHostHidden]
    public sealed class RotateTransform : Transform, IRotateTransform
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public RotateTransform();

        public double Angle { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty AngleProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double CenterX { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty CenterXProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double CenterY { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty CenterYProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Media.IRotateTransform.Angle { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Media.IRotateTransform.CenterX { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Media.IRotateTransform.CenterY { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

