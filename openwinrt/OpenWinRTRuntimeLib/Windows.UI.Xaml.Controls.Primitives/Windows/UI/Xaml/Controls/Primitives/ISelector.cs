namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(Selector)), Windows.Foundation.Metadata.Guid(0xe30eb3a5, 0xb36b, 0x42dc, 0x85, 0x27, 0xcd, 0x25, 0x13, 0x6c, 8, 60)]
    internal interface ISelector
    {
        event SelectionChangedEventHandler SelectionChanged;

        IReference<bool> IsSynchronizedWithCurrentItem { get; [param: In] set; }

        int SelectedIndex { get; [param: In] set; }

        object SelectedItem { get; [param: In] set; }

        object SelectedValue { get; [param: In] set; }

        string SelectedValuePath { get; [param: In] set; }
    }
}

