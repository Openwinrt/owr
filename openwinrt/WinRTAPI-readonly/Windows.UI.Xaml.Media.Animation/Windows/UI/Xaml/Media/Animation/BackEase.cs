namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), WebHostHidden, Activatable(0x6020000), Static(typeof(IBackEaseStatics), 0x6020000), Threading(ThreadingModel.Both)]
    public sealed class BackEase : EasingFunctionBase, IBackEase
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public BackEase();

        public double Amplitude { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty AmplitudeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Media.Animation.IBackEase.Amplitude { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

