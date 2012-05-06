namespace Windows.UI.Xaml.Data
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, ExclusiveTo(typeof(BindingOperations)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xe155ef73, 0x95a0, 0x4aab, 140, 0x7d, 0x2a, 0x47, 0xda, 7, 60, 0x79)]
    internal interface IBindingOperationsStatics
    {
        void SetBinding([In] DependencyObject target, [In] DependencyProperty dp, [In] BindingBase binding);
    }
}

