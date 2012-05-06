namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x589877fb, 0xfc7, 0x4036, 0x9d, 0x8b, 0x12, 0x7d, 250, 0x75, 0xc1, 0x6d), ExclusiveTo(typeof(ToggleButton)), WebHostHidden]
    internal interface IToggleButton
    {
        event RoutedEventHandler Checked;

        event RoutedEventHandler Indeterminate;

        event RoutedEventHandler Unchecked;

        IReference<bool> IsChecked { get; [param: In] set; }

        bool IsThreeState { get; [param: In] set; }
    }
}

