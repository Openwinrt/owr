namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI;
    using Windows.UI.Xaml;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Composable(typeof(IColorKeyFrameFactory), CompositionType.Protected, 0x6020000), WebHostHidden, Static(typeof(IColorKeyFrameStatics), 0x6020000), Threading(ThreadingModel.Both)]
    public class ColorKeyFrame : DependencyObject, IColorKeyFrame
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected ColorKeyFrame();

        public Windows.UI.Xaml.Media.Animation.KeyTime KeyTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty KeyTimeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Color Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ValueProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.Animation.KeyTime Windows.UI.Xaml.Media.Animation.IColorKeyFrame.KeyTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Color Windows.UI.Xaml.Media.Animation.IColorKeyFrame.Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

