namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Threading(ThreadingModel.Both), Version(0x6020000), WebHostHidden, Static(typeof(IEasingFunctionBaseStatics), 0x6020000), Composable(typeof(IEasingFunctionBaseFactory), CompositionType.Protected, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class EasingFunctionBase : DependencyObject, IEasingFunctionBase
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public double Ease([In] double normalizedTime);

        public Windows.UI.Xaml.Media.Animation.EasingMode EasingMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty EasingModeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.Animation.EasingMode Windows.UI.Xaml.Media.Animation.IEasingFunctionBase.EasingMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

