namespace Windows.UI.Xaml.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), Composable(typeof(IBindingBaseFactory), CompositionType.Public, 0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden]
    public class BindingBase : DependencyObject, IBindingBase
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public BindingBase();
    }
}

