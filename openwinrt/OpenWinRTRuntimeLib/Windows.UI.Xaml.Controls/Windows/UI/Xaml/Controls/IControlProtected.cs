namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), ExclusiveTo(typeof(Control)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x1791587a, 0x2a7c, 0x4981, 0xa2, 0xd8, 0xab, 0x99, 0xff, 0xfc, 0x65, 0xb9)]
    internal interface IControlProtected
    {
        DependencyObject GetTemplateChild([In] string childName);

        object DefaultStyleKey { get; [param: In] set; }
    }
}

