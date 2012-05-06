namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x1f7df263, 0xc14b, 0x4528, 0xb6, 240, 0x63, 0x79, 0x99, 0xd8, 60, 0xc6), WebHostHidden, ExclusiveTo(typeof(ContextMenuEventArgs)), Version(0x6020000)]
    internal interface IContextMenuEventArgs
    {
        double CursorLeft { get; }

        double CursorTop { get; }

        bool Handled { get; [param: In] set; }
    }
}

