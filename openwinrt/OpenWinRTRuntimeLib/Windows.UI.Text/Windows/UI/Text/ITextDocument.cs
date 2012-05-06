namespace Windows.UI.Text
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Windows.Foundation.Metadata.Guid(0xbeee4ddb, 0x90b2, 0x408c, 0xa2, 0xf6, 10, 10, 0xc3, 30, 0x33, 0xe4), Version(0x6020000)]
    public interface ITextDocument
    {
        int ApplyDisplayUpdates();
        int BatchDisplayUpdates();
        void BeginUndoGroup();
        bool CanCopy();
        bool CanPaste();
        bool CanRedo();
        bool CanUndo();
        void EndUndoGroup();
        ITextCharacterFormat GetDefaultCharacterFormat();
        ITextParagraphFormat GetDefaultParagraphFormat();
        ITextRange GetRange([In] int startPosition, [In] int endPosition);
        ITextRange GetRangeFromPoint([In] Point point, [In] PointOptions options);
        void GetText([In] TextGetOptions options, out string value);
        void LoadFromStream([In] TextSetOptions options, [In] IRandomAccessStream value);
        void Redo();
        void SaveToStream([In] TextGetOptions options, [In] IRandomAccessStream value);
        void SetDefaultCharacterFormat([In] ITextCharacterFormat value);
        void SetDefaultParagraphFormat([In] ITextParagraphFormat value);
        void SetText([In] TextSetOptions options, [In] string value);
        void Undo();

        Windows.UI.Text.CaretType CaretType { get; [param: In] set; }

        float DefaultTabStop { get; [param: In] set; }

        ITextSelection Selection { get; }

        uint UndoLimit { get; [param: In] set; }
    }
}

