namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;

    [Static(typeof(IRangeBaseStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Version(0x6020000), Composable(typeof(IRangeBaseFactory), CompositionType.Protected, 0x6020000), Threading(ThreadingModel.Both)]
    public class RangeBase : Control, IRangeBase, IRangeBaseOverrides
    {
        public event RangeBaseValueChangedEventHandler ValueChanged;

        public event RangeBaseValueChangedEventHandler Windows.UI.Xaml.Controls.Primitives.IRangeBase.ValueChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected RangeBase();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnMaximumChanged([In] double oldMaximum, [In] double newMaximum);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnMinimumChanged([In] double oldMinimum, [In] double newMinimum);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnValueChanged([In] double oldValue, [In] double newValue);

        public double LargeChange { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty LargeChangeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Maximum { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty MaximumProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Minimum { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty MinimumProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double SmallChange { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty SmallChangeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ValueProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IRangeBase.LargeChange { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Controls.Primitives.IRangeBase.Maximum { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Controls.Primitives.IRangeBase.Minimum { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Controls.Primitives.IRangeBase.SmallChange { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Controls.Primitives.IRangeBase.Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

