namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Static(typeof(IDoubleKeyFrameStatics), 0x6020000), Version(0x6020000), WebHostHidden, Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), Composable(typeof(IDoubleKeyFrameFactory), CompositionType.Protected, 0x6020000)]
    public class DoubleKeyFrame : DependencyObject, IDoubleKeyFrame
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected DoubleKeyFrame();

        public Windows.UI.Xaml.Media.Animation.KeyTime KeyTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty KeyTimeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ValueProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.Animation.KeyTime Windows.UI.Xaml.Media.Animation.IDoubleKeyFrame.KeyTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Media.Animation.IDoubleKeyFrame.Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

