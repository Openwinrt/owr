namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0xe9f3b9ff, 0x8e91, 0x4ecf, 0xa7, 7, 0xc9, 0x27, 0xf6, 0x94, 0xf8, 0x81), ExclusiveTo(typeof(ListBox))]
    internal interface IListBox
    {
        void ScrollIntoView([In] object item);
        void SelectAll();

        IVector<object> SelectedItems { get; }

        Windows.UI.Xaml.Controls.SelectionMode SelectionMode { get; [param: In] set; }
    }
}

