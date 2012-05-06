namespace Windows.UI.Text
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x5b9e4e57, 0xc072, 0x42a0, 0x89, 0x45, 0xaf, 80, 0x3e, 0xe5, 0x47, 0x68)]
    public interface ITextRange
    {
        bool CanPaste([In] int format);
        void ChangeCase([In] LetterCase value);
        void Collapse([In] bool value);
        void Copy();
        void Cut();
        int Delete([In] TextRangeUnit unit, [In] int count);
        int EndOf([In] TextRangeUnit unit, [In] bool extend);
        int Expand([In] TextRangeUnit unit);
        int FindText([In] string value, [In] int scanLength, [In] FindOptions options);
        void GetCharacterUtf32(out uint value, [In] int offset);
        ITextRange GetClone();
        object GetEmbeddedObject();
        int GetIndex([In] TextRangeUnit unit);
        void GetPoint([In] HorizontalCharacterAlignment horizontalAlign, [In] VerticalCharacterAlignment verticalAlign, [In] PointOptions options, out Point point);
        void GetRect([In] PointOptions options, out Rect rect, out int hit);
        void GetText([In] TextGetOptions options, out string value);
        void GetTextViaStream([In] TextGetOptions options, [In] IRandomAccessStream value);
        bool InRange([In] ITextRange range);
        void InsertImage([In] int width, [In] int height, [In] int ascent, [In] VerticalCharacterAlignment verticalAlign, [In] string alternateText, [In] IRandomAccessStream value);
        bool InStory([In] ITextRange range);
        bool IsEqual([In] ITextRange range);
        void MatchSelection();
        int Move([In] TextRangeUnit unit, [In] int count);
        int MoveEnd([In] TextRangeUnit unit, [In] int count);
        int MoveStart([In] TextRangeUnit unit, [In] int count);
        void Paste([In] int format);
        void ScrollIntoView([In] PointOptions value);
        void SetEmbeddedObject([In] object value);
        void SetIndex([In] TextRangeUnit unit, [In] int index, [In] bool extend);
        void SetPoint([In] Point point, [In] PointOptions options, [In] bool extend);
        void SetRange([In] int endPosition, [In] int startPosition);
        void SetText([In] TextSetOptions options, [In] string value);
        void SetTextViaStream([In] TextSetOptions options, [In] IRandomAccessStream value);
        int StartOf([In] TextRangeUnit unit, [In] bool extend);

        char Character { get; [param: In] set; }

        ITextCharacterFormat CharacterFormat { get; [param: In] set; }

        int EndPosition { get; [param: In] set; }

        ITextRange FormattedText { get; [param: In] set; }

        RangeGravity Gravity { get; [param: In] set; }

        int Length { get; }

        string Link { get; [param: In] set; }

        ITextParagraphFormat ParagraphFormat { get; [param: In] set; }

        int StartPosition { get; [param: In] set; }

        int StoryLength { get; }

        string Text { get; [param: In] set; }
    }
}

