namespace Windows.UI.Xaml.Shapes
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Media;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Composable(typeof(IShapeFactory), CompositionType.Protected, 0x6020000), Threading(ThreadingModel.Both), WebHostHidden, Static(typeof(IShapeStatics), 0x6020000)]
    public class Shape : FrameworkElement, IShape
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected Shape();

        public Brush Fill { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty FillProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Transform GeometryTransform { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.Stretch Stretch { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty StretchProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Brush Stroke { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public DoubleCollection StrokeDashArray { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty StrokeDashArrayProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PenLineCap StrokeDashCap { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty StrokeDashCapProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double StrokeDashOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty StrokeDashOffsetProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PenLineCap StrokeEndLineCap { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty StrokeEndLineCapProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PenLineJoin StrokeLineJoin { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty StrokeLineJoinProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double StrokeMiterLimit { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty StrokeMiterLimitProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty StrokeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PenLineCap StrokeStartLineCap { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty StrokeStartLineCapProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double StrokeThickness { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty StrokeThicknessProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Brush Windows.UI.Xaml.Shapes.IShape.Fill { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Transform Windows.UI.Xaml.Shapes.IShape.GeometryTransform { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.Stretch Windows.UI.Xaml.Shapes.IShape.Stretch { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Brush Windows.UI.Xaml.Shapes.IShape.Stroke { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public DoubleCollection Windows.UI.Xaml.Shapes.IShape.StrokeDashArray { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PenLineCap Windows.UI.Xaml.Shapes.IShape.StrokeDashCap { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Shapes.IShape.StrokeDashOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PenLineCap Windows.UI.Xaml.Shapes.IShape.StrokeEndLineCap { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PenLineJoin Windows.UI.Xaml.Shapes.IShape.StrokeLineJoin { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Shapes.IShape.StrokeMiterLimit { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PenLineCap Windows.UI.Xaml.Shapes.IShape.StrokeStartLineCap { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Shapes.IShape.StrokeThickness { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

