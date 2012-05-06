namespace Windows.UI.Xaml.Shapes
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Threading(ThreadingModel.Both), WebHostHidden, Activatable(0x6020000), Static(typeof(ILineStatics), 0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class Line : Shape, ILine
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Line();

        public double Windows.UI.Xaml.Shapes.ILine.X1 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Shapes.ILine.X2 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Shapes.ILine.Y1 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Shapes.ILine.Y2 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double X1 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty X1Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double X2 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty X2Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Y1 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty Y1Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Y2 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty Y2Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

