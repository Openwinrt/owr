namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Activatable(0x6020000), Threading(ThreadingModel.Both), Version(0x6020000), Static(typeof(IExponentialEaseStatics), 0x6020000), WebHostHidden]
    public sealed class ExponentialEase : EasingFunctionBase, IExponentialEase
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ExponentialEase();

        public double Exponent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ExponentProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Media.Animation.IExponentialEase.Exponent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

