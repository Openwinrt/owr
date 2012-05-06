namespace Windows.UI.Xaml.Documents
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Windows.Foundation.Metadata.Guid(0xac687aa1, 0x6a41, 0x43ff, 0x85, 30, 0x45, 0x34, 0x8a, 0xa2, 0xcf, 0x7b), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(TextPointer))]
    internal interface ITextPointer
    {
        Rect GetCharacterRect([In] Windows.UI.Xaml.Documents.LogicalDirection direction);
        TextPointer GetPositionAtOffset([In] int offset, [In] Windows.UI.Xaml.Documents.LogicalDirection direction);

        Windows.UI.Xaml.Documents.LogicalDirection LogicalDirection { get; }

        int Offset { get; }

        DependencyObject Parent { get; }

        FrameworkElement VisualParent { get; }
    }
}

