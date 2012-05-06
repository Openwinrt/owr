namespace Windows.UI.Text
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI;

    [Windows.Foundation.Metadata.Guid(0x5adef3db, 0x5fb, 0x442d, 0x80, 0x65, 100, 0x2a, 0xfe, 160, 0x2c, 0xed), Version(0x6020000)]
    public interface ITextCharacterFormat
    {
        ITextCharacterFormat GetClone();
        bool IsEqual([In] ITextCharacterFormat format);
        void SetClone([In] ITextCharacterFormat value);

        FormatEffect AllCaps { get; [param: In] set; }

        Color BackgroundColor { get; [param: In] set; }

        FormatEffect Bold { get; [param: In] set; }

        Windows.UI.Text.FontStretch FontStretch { get; [param: In] set; }

        Windows.UI.Text.FontStyle FontStyle { get; [param: In] set; }

        Color ForegroundColor { get; [param: In] set; }

        FormatEffect Hidden { get; [param: In] set; }

        FormatEffect Italic { get; [param: In] set; }

        float Kerning { get; [param: In] set; }

        string LanguageTag { get; [param: In] set; }

        Windows.UI.Text.LinkType LinkType { get; }

        string Name { get; [param: In] set; }

        FormatEffect Outline { get; [param: In] set; }

        float Position { get; [param: In] set; }

        FormatEffect ProtectedText { get; [param: In] set; }

        FormatEffect Shadow { get; [param: In] set; }

        float Size { get; [param: In] set; }

        FormatEffect SmallCaps { get; [param: In] set; }

        float Spacing { get; [param: In] set; }

        FormatEffect Strikethrough { get; [param: In] set; }

        FormatEffect Subscript { get; [param: In] set; }

        FormatEffect Superscript { get; [param: In] set; }

        Windows.UI.Text.TextScript TextScript { get; [param: In] set; }

        UnderlineType Underline { get; [param: In] set; }

        int Weight { get; [param: In] set; }
    }
}

