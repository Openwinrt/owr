namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), Composable(typeof(IStyleSelectorFactory), CompositionType.Public, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), WebHostHidden]
    public class StyleSelector : IStyleSelector, IStyleSelectorOverrides
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public StyleSelector();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Style SelectStyle([In] object item, [In] DependencyObject container);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual Style SelectStyleCore([In] object item, [In] DependencyObject container);
    }
}

