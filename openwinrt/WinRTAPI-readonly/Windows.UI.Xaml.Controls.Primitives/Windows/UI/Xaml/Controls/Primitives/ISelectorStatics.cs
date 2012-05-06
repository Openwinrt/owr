namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Windows.Foundation.Metadata.Guid(0x13300b06, 0xbd10, 0x4e09, 0xbf, 0xf7, 0x71, 0xef, 0xb8, 0xbb, 180, 0x2b), Version(0x6020000), ExclusiveTo(typeof(Selector)), WebHostHidden]
    internal interface ISelectorStatics
    {
        bool GetIsSelectionActive([In] DependencyObject element);

        DependencyProperty IsSynchronizedWithCurrentItemProperty { get; }

        DependencyProperty SelectedIndexProperty { get; }

        DependencyProperty SelectedItemProperty { get; }

        DependencyProperty SelectedValuePathProperty { get; }

        DependencyProperty SelectedValueProperty { get; }
    }
}

