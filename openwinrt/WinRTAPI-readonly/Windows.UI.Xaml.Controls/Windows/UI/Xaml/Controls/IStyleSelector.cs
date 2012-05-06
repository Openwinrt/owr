namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(StyleSelector)), WebHostHidden, Windows.Foundation.Metadata.Guid(0xd1113f67, 0xd8c1, 0x4ae4, 0x98, 240, 0xd8, 80, 0x45, 2, 240, 0x8b), Version(0x6020000)]
    internal interface IStyleSelector
    {
        Style SelectStyle([In] object item, [In] DependencyObject container);
    }
}

