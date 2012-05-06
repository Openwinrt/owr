namespace Windows.UI.Xaml.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Static(typeof(IBindingOperationsStatics), 0x6020000), Threading(ThreadingModel.Both), WebHostHidden]
    public sealed class BindingOperations : IBindingOperations
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetBinding([In] DependencyObject target, [In] DependencyProperty dp, [In] BindingBase binding);
    }
}

