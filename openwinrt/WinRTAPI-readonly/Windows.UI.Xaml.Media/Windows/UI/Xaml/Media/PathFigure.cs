namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Markup;

    [Activatable(0x6020000), ContentProperty(Name="Segments"), Static(typeof(IPathFigureStatics), 0x6020000), WebHostHidden, Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both)]
    public sealed class PathFigure : DependencyObject, IPathFigure
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PathFigure();

        public bool IsClosed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsClosedProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsFilled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsFilledProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PathSegmentCollection Segments { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty SegmentsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point StartPoint { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty StartPointProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Media.IPathFigure.IsClosed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Media.IPathFigure.IsFilled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PathSegmentCollection Windows.UI.Xaml.Media.IPathFigure.Segments { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Point Windows.UI.Xaml.Media.IPathFigure.StartPoint { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

