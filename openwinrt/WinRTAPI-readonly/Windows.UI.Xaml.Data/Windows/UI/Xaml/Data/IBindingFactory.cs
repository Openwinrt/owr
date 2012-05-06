namespace Windows.UI.Xaml.Data
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xff42bb08, 0xc39e, 0x4f7e, 0x84, 0x34, 0xa1, 0x56, 0x90, 0x83, 0x88, 60), ExclusiveTo(typeof(Binding)), WebHostHidden, Version(0x6020000)]
    internal interface IBindingFactory
    {
        Binding CreateInstance([In] object outer, out object inner);
    }
}

