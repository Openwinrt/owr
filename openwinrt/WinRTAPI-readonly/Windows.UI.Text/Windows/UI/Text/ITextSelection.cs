namespace Windows.UI.Text
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xa6d36724, 0xf28f, 0x430a, 0xb2, 0xcf, 0xc3, 0x43, 0x67, 30, 0xc0, 0xe9), Version(0x6020000)]
    public interface ITextSelection : ITextRange
    {
        int EndKey([In] TextRangeUnit unit, [In] bool extend);
        int HomeKey([In] TextRangeUnit unit, [In] bool extend);
        int MoveDown([In] TextRangeUnit unit, [In] int count, [In] bool extend);
        int MoveLeft([In] TextRangeUnit unit, [In] int count, [In] bool extend);
        int MoveRight([In] TextRangeUnit unit, [In] int count, [In] bool extend);
        int MoveUp([In] TextRangeUnit unit, [In] int count, [In] bool extend);
        void TypeText([In] string value);

        SelectionOptions Options { get; [param: In] set; }

        SelectionType Type { get; }
    }
}

