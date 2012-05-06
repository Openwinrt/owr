namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ButtonBase)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x389b7c71, 0x5220, 0x42b2, 0x99, 0x92, 0x26, 0x90, 0xc1, 0xa6, 0x70, 0x2f), Version(0x6020000)]
    internal interface IButtonBaseFactory
    {
        ButtonBase CreateInstance([In] object outer, out object inner);
    }
}

