namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Threading(ThreadingModel.Both), Version(0x6020000), Activatable(0x6020000), Static(typeof(IBounceEaseStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden]
    public sealed class BounceEase : EasingFunctionBase, IBounceEase
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public BounceEase();

        public int Bounces { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty BouncesProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Bounciness { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty BouncinessProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Xaml.Media.Animation.IBounceEase.Bounces { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Media.Animation.IBounceEase.Bounciness { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

