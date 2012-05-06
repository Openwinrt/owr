namespace Windows.UI.Xaml.Data
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x22dafc3a, 0x7701, 0x4666, 0xa1, 0xba, 0x98, 0x59, 0xbd, 0xcf, 0xec, 0x34), Version(0x6020000), ExclusiveTo(typeof(BindingBase)), WebHostHidden]
    internal interface IBindingBaseFactory
    {
        BindingBase CreateInstance([In] object outer, out object inner);
    }
}

