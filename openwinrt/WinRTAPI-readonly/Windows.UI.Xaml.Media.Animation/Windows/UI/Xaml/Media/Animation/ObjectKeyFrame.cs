namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Threading(ThreadingModel.Both), Composable(typeof(IObjectKeyFrameFactory), CompositionType.Protected, 0x6020000), Version(0x6020000), Static(typeof(IObjectKeyFrameStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden]
    public class ObjectKeyFrame : DependencyObject, IObjectKeyFrame
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected ObjectKeyFrame();

        public Windows.UI.Xaml.Media.Animation.KeyTime KeyTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty KeyTimeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ValueProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.Animation.KeyTime Windows.UI.Xaml.Media.Animation.IObjectKeyFrame.KeyTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public object Windows.UI.Xaml.Media.Animation.IObjectKeyFrame.Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

