namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Windows.Foundation.Metadata.Guid(0x8add66d, 0xe2e, 0x43a0, 0xae, 0xca, 0x8f, 170, 0x94, 0xb9, 0xd0, 0x17), Version(0x6020000), ExclusiveTo(typeof(StyleSelector)), WebHostHidden]
    internal interface IStyleSelectorOverrides
    {
        Style SelectStyleCore([In] object item, [In] DependencyObject container);
    }
}

