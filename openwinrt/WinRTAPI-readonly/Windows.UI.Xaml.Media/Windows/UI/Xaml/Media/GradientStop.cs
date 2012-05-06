namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Markup;

    [Static(typeof(IGradientStopStatics), 0x6020000), WebHostHidden, Activatable(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), ContentProperty(Name="Color"), Threading(ThreadingModel.Both)]
    public sealed class GradientStop : DependencyObject, IGradientStop
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public GradientStop();

        public Windows.UI.Color Color { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ColorProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Offset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty OffsetProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Color Windows.UI.Xaml.Media.IGradientStop.Color { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Media.IGradientStop.Offset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

