namespace Windows.UI.Text
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x2cf8cfa6, 0x4676, 0x498a, 0x93, 0xf5, 0xbb, 0xdb, 0xfc, 11, 0xd8, 0x83), Version(0x6020000)]
    public interface ITextParagraphFormat
    {
        void AddTab([In] float position, [In] TabAlignment align, [In] TabLeader leader);
        void ClearAllTabs();
        void DeleteTab([In] float position);
        ITextParagraphFormat GetClone();
        void GetTab([In] int index, out float position, out TabAlignment align, out TabLeader leader);
        bool IsEqual([In] ITextParagraphFormat format);
        void SetClone([In] ITextParagraphFormat format);
        void SetIndents([In] float start, [In] float left, [In] float right);
        void SetLineSpacing([In] Windows.UI.Text.LineSpacingRule rule, [In] float spacing);

        ParagraphAlignment Alignment { get; [param: In] set; }

        float FirstLineIndent { get; }

        FormatEffect KeepTogether { get; [param: In] set; }

        FormatEffect KeepWithNext { get; [param: In] set; }

        float LeftIndent { get; }

        float LineSpacing { get; }

        Windows.UI.Text.LineSpacingRule LineSpacingRule { get; }

        MarkerAlignment ListAlignment { get; [param: In] set; }

        int ListLevelIndex { get; [param: In] set; }

        int ListStart { get; [param: In] set; }

        MarkerStyle ListStyle { get; [param: In] set; }

        float ListTab { get; [param: In] set; }

        MarkerType ListType { get; [param: In] set; }

        FormatEffect NoLineNumber { get; [param: In] set; }

        FormatEffect PageBreakBefore { get; [param: In] set; }

        float RightIndent { get; [param: In] set; }

        float SpaceAfter { get; [param: In] set; }

        float SpaceBefore { get; [param: In] set; }

        ParagraphStyle Style { get; [param: In] set; }

        int TabCount { get; }

        FormatEffect WidowControl { get; [param: In] set; }
    }
}

