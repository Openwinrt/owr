namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Markup;

    [ContentProperty(Name="Color"), WebHostHidden, Version(0x6020000), Activatable(0x6020000), Threading(ThreadingModel.Both), Activatable(typeof(ISolidColorBrushFactory), 0x6020000), Static(typeof(ISolidColorBrushStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class SolidColorBrush : Brush, ISolidColorBrush
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SolidColorBrush();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SolidColorBrush([In] Windows.UI.Color color);

        public Windows.UI.Color Color { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ColorProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Color Windows.UI.Xaml.Media.ISolidColorBrush.Color { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

