namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Threading(ThreadingModel.Both), Activatable(0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Static(typeof(IElasticEaseStatics), 0x6020000)]
    public sealed class ElasticEase : EasingFunctionBase, IElasticEase
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ElasticEase();

        public int Oscillations { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty OscillationsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Springiness { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty SpringinessProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Xaml.Media.Animation.IElasticEase.Oscillations { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Media.Animation.IElasticEase.Springiness { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

