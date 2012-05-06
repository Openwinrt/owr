namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Media;

    [WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Static(typeof(ITickBarStatics), 0x6020000), Activatable(0x6020000), Version(0x6020000)]
    public sealed class TickBar : FrameworkElement, ITickBar
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public TickBar();

        public Brush Fill { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty FillProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Brush Windows.UI.Xaml.Controls.Primitives.ITickBar.Fill { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

